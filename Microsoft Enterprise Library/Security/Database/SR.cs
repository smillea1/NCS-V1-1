using System.Globalization;
using System.Resources;
// WARNING:
// This file generated by the Microsoft DataWarehouse String Resource Tool 1.13.5000.0
// from information in SR.strings.   
// DO NO MODIFY THIS FILE'S CONTENTS, THEY WILL BE OVERWRITTEN
//

namespace Microsoft.Practices.EnterpriseLibrary.Security.Database
{
    internal class SR
    {
        public static CultureInfo Culture
        {
            get { return Keys.Culture; }
            set { Keys.Culture = value; }
        }

        public static string NamePasswordCredentialsAreNull
        {
            get { return Keys.GetString(Keys.NamePasswordCredentialsAreNull); }
        }

        public static string NamePasswordCredentialsInvalid
        {
            get { return Keys.GetString(Keys.NamePasswordCredentialsInvalid); }
        }

        public static string DBAuthenticationProviderConfigDataIsNull
        {
            get { return Keys.GetString(Keys.DBAuthenticationProviderConfigDataIsNull); }
        }

        public static string DBAuthenticationProviderConfigDataInvalid
        {
            get { return Keys.GetString(Keys.DBAuthenticationProviderConfigDataInvalid); }
        }

        public static string IdentityIsNull
        {
            get { return Keys.GetString(Keys.IdentityIsNull); }
        }

        public static string IdentityInvalid
        {
            get { return Keys.GetString(Keys.IdentityInvalid); }
        }

        public static string DBProfileProviderConfigDataIsNull
        {
            get { return Keys.GetString(Keys.DBProfileProviderConfigDataIsNull); }
        }

        public static string DBProfileProviderConfigDataInvalid
        {
            get { return Keys.GetString(Keys.DBProfileProviderConfigDataInvalid); }
        }

        public static string ProfileDictionaryZeroItems
        {
            get { return Keys.GetString(Keys.ProfileDictionaryZeroItems); }
        }

        public static string ConversionException(string keyValue, string type)
        {
            return Keys.GetString(Keys.ConversionException, keyValue, type);
        }

        public static string ProfileIsNull
        {
            get { return Keys.GetString(Keys.ProfileIsNull); }
        }

        public static string ProfileExceedsMaxLength(int length, int maxLength)
        {
            return Keys.GetString(Keys.ProfileExceedsMaxLength, length, maxLength);
        }

        public static string LoadingProfileException(string userName)
        {
            return Keys.GetString(Keys.LoadingProfileException, userName);
        }

        public static string SavingProfileException(string userName)
        {
            return Keys.GetString(Keys.SavingProfileException, userName);
        }

        public static string NoUserExists(string userName)
        {
            return Keys.GetString(Keys.NoUserExists, userName);
        }

        public static string NoRoleExists(string roleName)
        {
            return Keys.GetString(Keys.NoRoleExists, roleName);
        }

        public static string BatchNoUserExists
        {
            get { return Keys.GetString(Keys.BatchNoUserExists); }
        }

        public static string BatchNoRoleExists
        {
            get { return Keys.GetString(Keys.BatchNoRoleExists); }
        }

        internal class Keys
        {
            private static ResourceManager resourceManager =
                new ResourceManager("Microsoft.Practices.EnterpriseLibrary.Security.Database.SR", typeof(SR).Module.Assembly);

            private static CultureInfo culture = null;

            public static CultureInfo Culture
            {
                get { return culture; }
                set { culture = value; }
            }

            public static string GetString(string key)
            {
                return resourceManager.GetString(key, culture);
            }

            public static string GetString(string key, params object[] args)
            {
                string msg = resourceManager.GetString(key, culture);
                msg = string.Format(msg, args);
                return msg;
            }

            public const string NamePasswordCredentialsAreNull = "NamePasswordCredentialsAreNull";
            public const string NamePasswordCredentialsInvalid = "NamePasswordCredentialsInvalid";
            public const string DBAuthenticationProviderConfigDataIsNull = "DBAuthenticationProviderConfigDataIsNull";
            public const string DBAuthenticationProviderConfigDataInvalid = "DBAuthenticationProviderConfigDataInvalid";
            public const string IdentityIsNull = "IdentityIsNull";
            public const string IdentityInvalid = "IdentityInvalid";
            public const string DBProfileProviderConfigDataIsNull = "DBProfileProviderConfigDataIsNull";
            public const string DBProfileProviderConfigDataInvalid = "DBProfileProviderConfigDataInvalid";
            public const string ProfileDictionaryZeroItems = "ProfileDictionaryZeroItems";
            public const string ConversionException = "ConversionException";
            public const string ProfileIsNull = "ProfileIsNull";
            public const string ProfileExceedsMaxLength = "ProfileExceedsMaxLength";
            public const string LoadingProfileException = "LoadingProfileException";
            public const string SavingProfileException = "SavingProfileException";
            public const string NoUserExists = "NoUserExists";
            public const string NoRoleExists = "NoRoleExists";
            public const string BatchNoUserExists = "BatchNoUserExists";
            public const string BatchNoRoleExists = "BatchNoRoleExists";
        }

    }
}