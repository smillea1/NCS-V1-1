//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Security Application Block
//===============================================================================
// Copyright � Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

#if  UNIT_TESTS
using NUnit.Framework;

namespace Microsoft.Practices.EnterpriseLibrary.Security.Configuration.Tests
{
    [TestFixture]
    public class AuthorizationDataFixture
    {
        [Test]
        public void ConstructorTest()
        {
            SecuritySettings settings = new SecuritySettings();
            Assert.IsNotNull(settings.AuthorizationProviders);
            Assert.AreEqual(0, settings.AuthorizationProviders.Count);
        }

        [Test]
        public void SerializationTest()
        {
            Utility.SerializationTest(new AuthorizationProviderDataCollection());
        }
    }
}

#endif