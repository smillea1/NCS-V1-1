//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Caching Application Block
//===============================================================================
// Copyright � Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

#if  UNIT_TESTS
using System;
using System.Collections;
using System.Threading;
using Microsoft.Practices.EnterpriseLibrary.Caching.Expirations;
using Microsoft.Practices.EnterpriseLibrary.Caching.Expirations.Tests;
using NUnit.Framework;

namespace Microsoft.Practices.EnterpriseLibrary.Caching.Tests
{
    [TestFixture]
    public class ExpirationTaskFixture : ICacheOperations
    {
        private Hashtable inMemoryCache;
        private ExpirationTask expirer;
        private string expiredItemKeys = "";
        public static int callbackCount;
        public static CacheItemRemovedReason callbackReason;

        [SetUp]
        public void SetUp()
        {
            inMemoryCache = new Hashtable();
            expirer = new ExpirationTask(this);
            expiredItemKeys = "";
            callbackCount = 0;
            callbackReason = CacheItemRemovedReason.Unknown;
        }

        [Test]
        public void NoExpirationsFromEmptyCache()
        {
            int expiredCount = expirer.MarkAsExpired(inMemoryCache);
            Assert.AreEqual(0, expiredCount, "Nothing can be marked in an empty cache");
        }

        [Test]
        public void NoExpirationsFoundIfNoItemsAreToBeExpired()
        {
            CacheItem neverExpiredItem = CreateNeverExpiredCacheItem("key", "value");
            AddCacheItem("key", neverExpiredItem);

            int expiredCount = expirer.MarkAsExpired(inMemoryCache);
            Assert.AreEqual(0, expiredCount, "Nothing in cache to expire");
        }

        [Test]
        public void WillFindSingleItemToBeExpired()
        {
            CacheItem itemToMark = CreateAlwaysExpiredCacheItem("key", "value");
            AddCacheItem("key", itemToMark);

            int expiredCount = expirer.MarkAsExpired(inMemoryCache);
            Assert.AreEqual(1, expiredCount, "Single item should be found to expire");
        }

        [Test]
        public void ItemToBeExpiredAreMarkedExpired()
        {
            CacheItem itemToMark = CreateAlwaysExpiredCacheItem("key", "value");
            AddCacheItem("key", itemToMark);

            expirer.MarkAsExpired(inMemoryCache);

            Assert.IsTrue(itemToMark.WillBeExpired, "The found item should be marked for expiration internally");
        }

        [Test]
        public void NothingExpiredIfNothingInCache()
        {
            expirer.SweepExpiredItemsFromCache(inMemoryCache);
            Assert.AreEqual("", expiredItemKeys, "No items to sweep from cache if cache is empty");
        }

        [Test]
        public void NothingExpiredIfNothingMarked()
        {
            CacheItem itemNeverExpired = CreateNeverExpiredCacheItem("key", "value");
            AddCacheItem("key", itemNeverExpired);
            expirer.SweepExpiredItemsFromCache(inMemoryCache);

            Assert.AreEqual("", expiredItemKeys, "No items to sweep from cache if none expired");
        }

        [Test]
        public void SweepWillExpireSingleMarkedItem()
        {
            CacheItem itemToSweep = CreateAlwaysExpiredCacheItem("key", "value");
            itemToSweep.WillBeExpired = true;
            AddCacheItem("key", itemToSweep);
            expirer.SweepExpiredItemsFromCache(inMemoryCache);

            Assert.AreEqual("key", expiredItemKeys, "Single item to sweep should be found");
        }

        [Test]
        public void SweepWillExpireAllMarkedItems()
        {
            CacheItem itemOne = CreateAlwaysExpiredCacheItem("1", "value");
            itemOne.WillBeExpired = true;
            CacheItem itemTwo = CreateNeverExpiredCacheItem("key", "value");
            CacheItem itemThree = CreateAlwaysExpiredCacheItem("3", "value");
            itemThree.WillBeExpired = true;

            AddCacheItem("1", itemOne);
            AddCacheItem("2", itemTwo);
            AddCacheItem("3", itemThree);

            expirer.SweepExpiredItemsFromCache(inMemoryCache);

            Assert.AreEqual("31", expiredItemKeys, "Only those items marked as expired should be swept");
        }

        [Test]
        public void MarkAndSweepWillFindExpirationsAndSweepOutOfCache()
        {
            CacheItem itemOne = CreateAlwaysExpiredCacheItem("1", "value");
            CacheItem itemTwo = CreateNeverExpiredCacheItem("2", "value");
            itemOne.WillBeExpired = true;

            AddCacheItem("1", itemOne);
            AddCacheItem("2", itemTwo);

            expirer.DoExpirations();

            CacheItem firstItem = (CacheItem)inMemoryCache["1"];
            CacheItem secondItem = (CacheItem)inMemoryCache["2"];

            Assert.IsTrue(firstItem.HasExpired(), "Expired item should have been removed from inMemoryCache");
            Assert.IsFalse(secondItem.HasExpired(), "Unexpired item should still be in cache");
            Assert.AreEqual("1", expiredItemKeys, "Process should have swept itemOne value out of  persistent cache");
        }

        [Test]
        public void CanDoMarkAndSweepInBackground()
        {
            CacheItem itemOne = new CacheItem("1", "value", CacheItemPriority.Normal, null, new AbsoluteTime(TimeSpan.FromSeconds(0.5)));
            AddCacheItem("1", itemOne);

            ExpirationTask expirer = new ExpirationTask(this);
            BackgroundScheduler scheduler =
                new BackgroundScheduler(expirer, null);
            scheduler.Start();

            Thread.Sleep(1000);

            scheduler.ExpirationTimeoutExpired(null);

            Thread.Sleep(100);
            scheduler.Stop();

            Assert.AreEqual("1", expiredItemKeys, "Item should have been expired in the background");
        }

        [Test]
        public void RemovalAfterMarkingDoesNotTriggerSweepForItem()
        {
            CacheItem removedItem = CreateNeverExpiredCacheItem("key", "value");
            removedItem.WillBeExpired = true;
            removedItem.TouchedByUserAction(true);
            AddCacheItem("key", removedItem);

            ExpirationTask expirer = new ExpirationTask(this);
            expirer.SweepExpiredItemsFromCache(inMemoryCache);

            Assert.AreEqual("", expiredItemKeys, "Items removed through user action during expiration should not be further expired.");
            Assert.IsFalse(removedItem.WillBeExpired, "User removal of this object should reset its expiration flag");
        }

        [Test]
        public void WillDoCallbackAtExpiration()
        {
            CacheItem removedItem = new CacheItem("1", "value", CacheItemPriority.Normal, new MockRefreshAction(), new AlwaysExpired());
            removedItem.WillBeExpired = true;
            AddCacheItem("1", removedItem);

            ExpirationTask expirer = new ExpirationTask(this);
            expirer.SweepExpiredItemsFromCache(inMemoryCache);

            Thread.Sleep(250);

            Assert.AreEqual(1, callbackCount, "Refresh action should be taken for expired items if it exists");
            Assert.AreEqual(CacheItemRemovedReason.Expired, callbackReason);
        }

        [Test]
        public void DoesNotCallbackIfRemoveFromCacheThrowsException()
        {
            CacheItem exceptionThrowingCacheItem = new CacheItem("ThrowException", "value", CacheItemPriority.Normal, new MockRefreshAction(), null);
            exceptionThrowingCacheItem.WillBeExpired = true;
            AddCacheItem("ThrowException", exceptionThrowingCacheItem);

            ExpirationTask expirer = new ExpirationTask(this);
            expirer.SweepExpiredItemsFromCache(inMemoryCache);

            Thread.Sleep(250);

            Assert.AreEqual(0, callbackCount);
        }

        [Test]
        public void ExceptionThrownInCallbackDoesNotStopOtherCallbacksFromExecuting()
        {
            CacheItem exceptionThrowingCacheItem = new CacheItem("ThrowException", "value", CacheItemPriority.Normal, new ExceptionThrowingMockRefreshAction(), null);
            CacheItem normalCacheItem = new CacheItem("normal", "value2", CacheItemPriority.Normal, new MockRefreshAction(), null);
            exceptionThrowingCacheItem.WillBeExpired = true;
            normalCacheItem.WillBeExpired = true;
            AddCacheItem("ThrowException", exceptionThrowingCacheItem);
            AddCacheItem("normal", normalCacheItem);

            ExpirationTask expirer = new ExpirationTask(this);
            expirer.SweepExpiredItemsFromCache(inMemoryCache);

            Thread.Sleep(250);

            Assert.AreEqual(1, callbackCount, "Second item was still refreshed despite first refresh action throwing exception");
            Assert.AreEqual(CacheItemRemovedReason.Expired, callbackReason);
        }

        private void AddCacheItem(string key, CacheItem itemToAdd)
        {
            inMemoryCache.Add(key, itemToAdd);
        }

        public Hashtable GetCurrentCacheState()
        {
            return inMemoryCache;
        }

        public void RemoveItemFromCache(string keyToRemove, CacheItemRemovedReason removalReason)
        {
            if (keyToRemove == "ThrowException")
            {
                throw new Exception();
            }

            ExpirationTaskFixture.callbackCount++;
            ExpirationTaskFixture.callbackReason = removalReason;

            expiredItemKeys += keyToRemove;
        }

        private CacheItem CreateNeverExpiredCacheItem(string name, string value)
        {
            return new CacheItem(name, value, CacheItemPriority.Normal, null, new NeverExpired());
        }

        private CacheItem CreateAlwaysExpiredCacheItem(string name, string value)
        {
            return new CacheItem(name, value, CacheItemPriority.Normal, null, new AlwaysExpired());
        }

        private class MockRefreshAction : ICacheItemRefreshAction
        {
            public void Refresh(string removedKey, object expiredValue, CacheItemRemovedReason removalReason)
            {
                ExpirationTaskFixture.callbackCount++;
                ExpirationTaskFixture.callbackReason = removalReason;
            }
        }

        private class ExceptionThrowingMockRefreshAction : ICacheItemRefreshAction
        {
            public void Refresh(string removedKey, object expiredValue, CacheItemRemovedReason removalReason)
            {
                throw new Exception("Test exception from ExceptionThrowingMockRefreshAction");
            }
        }
    }
}

#endif