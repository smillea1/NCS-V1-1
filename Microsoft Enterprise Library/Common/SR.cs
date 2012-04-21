// WARNING:
// This file generated by the Microsoft DataWarehouse String Resource Tool 1.13.5000.0
// from information in SR.strings.   
// DO NO MODIFY THIS FILE'S CONTENTS, THEY WILL BE OVERWRITTEN
//
namespace Microsoft.Practices.EnterpriseLibrary.Common
{
	using System;
	using System.Resources;
	using System.Globalization;

	internal class SR
	{
		public static string ExceptionAccessDeniedFailure
		{
			get { return Keys.GetString( Keys.ExceptionAccessDeniedFailure ); }
		}
		public static string ExceptionCollectionModified
		{
			get { return Keys.GetString( Keys.ExceptionCollectionModified ); }
		}
		public static string ExceptionCreateInstanceFailure (string name, string value)
		{
			return Keys.GetString( Keys.ExceptionCreateInstanceFailure, name, value );
		}
		public static string ExceptionSetRawValueFailure (string name, string value)
		{
			return Keys.GetString( Keys.ExceptionSetRawValueFailure, name, value );
		}
		public static string ExceptionCollectionReadOnly
		{
			get { return Keys.GetString( Keys.ExceptionCollectionReadOnly ); }
		}
		public static string ExceptionIncrementValueFailure (string name, string value)
		{
			return Keys.GetString( Keys.ExceptionIncrementValueFailure, name, value );
		}
		public static string ExceptionDecrementValueFailure (string name, string value)
		{
			return Keys.GetString( Keys.ExceptionDecrementValueFailure, name, value );
		}
		public static string ExceptionDuplicateEntry (string name)
		{
			return Keys.GetString( Keys.ExceptionDuplicateEntry, name );
		}
		public static string ExceptionDetails
		{
			get { return Keys.GetString( Keys.ExceptionDetails ); }
		}
		public static string ExceptionStackTraceDetails
		{
			get { return Keys.GetString( Keys.ExceptionStackTraceDetails ); }
		}
		public static string ExceptionSummary
		{
			get { return Keys.GetString( Keys.ExceptionSummary ); }
		}
		public static string ExceptionStringArray
		{
			get { return Keys.GetString( Keys.ExceptionStringArray ); }
		}
		public static string ExceptionByteArrayValueMustBeGreaterThanZeroBytes
		{
			get { return Keys.GetString( Keys.ExceptionByteArrayValueMustBeGreaterThanZeroBytes ); }
		}
		public static string ExceptionEmptyString (string name)
		{
			return Keys.GetString( Keys.ExceptionEmptyString, name );
		}
		public static string ExceptionExpectedType (string typeName)
		{
			return Keys.GetString( Keys.ExceptionExpectedType, typeName );
		}
		public static string ExceptionInvalidNullNameArgument (string name)
		{
			return Keys.GetString( Keys.ExceptionInvalidNullNameArgument, name );
		}
		public static string ExceptionDecrypting
		{
			get { return Keys.GetString( Keys.ExceptionDecrypting ); }
		}
		public static string ExceptionCreatingSymmetricAlgorithmInstance
		{
			get { return Keys.GetString( Keys.ExceptionCreatingSymmetricAlgorithmInstance ); }
		}
		public static string ExceptionCastingSymmetricAlgorithmInstance
		{
			get { return Keys.GetString( Keys.ExceptionCastingSymmetricAlgorithmInstance ); }
		}
		public static string ExceptionCreatingHashAlgorithmInstance
		{
			get { return Keys.GetString( Keys.ExceptionCreatingHashAlgorithmInstance ); }
		}
		public static string ExceptionCastingHashAlgorithmInstance
		{
			get { return Keys.GetString( Keys.ExceptionCastingHashAlgorithmInstance ); }
		}
		public static string ExceptionEnumerationNotDefined (string variableName, string typeName)
		{
			return Keys.GetString( Keys.ExceptionEnumerationNotDefined, variableName, typeName );
		}
		public static string DpapiFormattingError (int errorCode)
		{
			return Keys.GetString( Keys.DpapiFormattingError, errorCode );
		}
		public static string DpapiMustHaveEntropyForMachineMode
		{
			get { return Keys.GetString( Keys.DpapiMustHaveEntropyForMachineMode ); }
		}
		public static string DpapiZeroLengthEntropy
		{
			get { return Keys.GetString( Keys.DpapiZeroLengthEntropy ); }
		}
		public static string DpapiAllocatingEntropyBuffer
		{
			get { return Keys.GetString( Keys.DpapiAllocatingEntropyBuffer ); }
		}
		public static string DpapiEncryptionFailed (string reason)
		{
			return Keys.GetString( Keys.DpapiEncryptionFailed, reason );
		}
		public static string DpapiUnableToAllocateCipherTextBuffer
		{
			get { return Keys.GetString( Keys.DpapiUnableToAllocateCipherTextBuffer ); }
		}
		public static string DpapiDecryptionFailed (string reason)
		{
			return Keys.GetString( Keys.DpapiDecryptionFailed, reason );
		}
		public static string InvalidHexString
		{
			get { return Keys.GetString( Keys.InvalidHexString ); }
		}
		public static string EnterpriseLibraryCryptography
		{
			get { return Keys.GetString( Keys.EnterpriseLibraryCryptography ); }
		}
		public static string LogName
		{
			get { return Keys.GetString( Keys.LogName ); }
		}
		public static string MachineName
		{
			get { return Keys.GetString( Keys.MachineName ); }
		}
		public static string FailureLogSource
		{
			get { return Keys.GetString( Keys.FailureLogSource ); }
		}
		public static string LineSeperator
		{
			get { return Keys.GetString( Keys.LineSeperator ); }
		}
		public static string WmiEventFailure (string eventName, string exceptionMessage)
		{
			return Keys.GetString( Keys.WmiEventFailure, eventName, exceptionMessage );
		}
		public static string DefaultInstanceName
		{
			get { return Keys.GetString( Keys.DefaultInstanceName ); }
		}
		public static string GlobalInstanceName
		{
			get { return Keys.GetString( Keys.GlobalInstanceName ); }
		}
		public static string AppSettingApplicationName
		{
			get { return Keys.GetString( Keys.AppSettingApplicationName ); }
		}
		public static string ExceptionType
		{
			get { return Keys.GetString( Keys.ExceptionType ); }
		}

		internal class Keys 
		{
			static ResourceManager resourceManager = 
				new ResourceManager("Microsoft.Practices.EnterpriseLibrary.Common.SR", typeof(Microsoft.Practices.EnterpriseLibrary.Common.SR).Module.Assembly );

			public static string GetString( string key )
			{
				return resourceManager.GetString( key, Resources.CultureInfo );
			}
			public static string GetString( string key, params object[] args )
			{
				string msg = resourceManager.GetString( key, Resources.CultureInfo );
				msg = string.Format( msg, args );
				return msg;
			}

			public const string ExceptionAccessDeniedFailure = "ExceptionAccessDeniedFailure";
			public const string ExceptionCollectionModified = "ExceptionCollectionModified";
			public const string ExceptionCreateInstanceFailure = "ExceptionCreateInstanceFailure";
			public const string ExceptionSetRawValueFailure = "ExceptionSetRawValueFailure";
			public const string ExceptionCollectionReadOnly = "ExceptionCollectionReadOnly";
			public const string ExceptionIncrementValueFailure = "ExceptionIncrementValueFailure";
			public const string ExceptionDecrementValueFailure = "ExceptionDecrementValueFailure";
			public const string ExceptionDuplicateEntry = "ExceptionDuplicateEntry";
			public const string ExceptionDetails = "ExceptionDetails";
			public const string ExceptionStackTraceDetails = "ExceptionStackTraceDetails";
			public const string ExceptionSummary = "ExceptionSummary";
			public const string ExceptionStringArray = "ExceptionStringArray";
			public const string ExceptionByteArrayValueMustBeGreaterThanZeroBytes = "ExceptionByteArrayValueMustBeGreaterThanZeroBytes";
			public const string ExceptionEmptyString = "ExceptionEmptyString";
			public const string ExceptionExpectedType = "ExceptionExpectedType";
			public const string ExceptionInvalidNullNameArgument = "ExceptionInvalidNullNameArgument";
			public const string ExceptionDecrypting = "ExceptionDecrypting";
			public const string ExceptionCreatingSymmetricAlgorithmInstance = "ExceptionCreatingSymmetricAlgorithmInstance";
			public const string ExceptionCastingSymmetricAlgorithmInstance = "ExceptionCastingSymmetricAlgorithmInstance";
			public const string ExceptionCreatingHashAlgorithmInstance = "ExceptionCreatingHashAlgorithmInstance";
			public const string ExceptionCastingHashAlgorithmInstance = "ExceptionCastingHashAlgorithmInstance";
			public const string ExceptionEnumerationNotDefined = "ExceptionEnumerationNotDefined";
			public const string DpapiFormattingError = "DpapiFormattingError";
			public const string DpapiMustHaveEntropyForMachineMode = "DpapiMustHaveEntropyForMachineMode";
			public const string DpapiZeroLengthEntropy = "DpapiZeroLengthEntropy";
			public const string DpapiAllocatingEntropyBuffer = "DpapiAllocatingEntropyBuffer";
			public const string DpapiEncryptionFailed = "DpapiEncryptionFailed";
			public const string DpapiUnableToAllocateCipherTextBuffer = "DpapiUnableToAllocateCipherTextBuffer";
			public const string DpapiDecryptionFailed = "DpapiDecryptionFailed";
			public const string InvalidHexString = "InvalidHexString";
			public const string EnterpriseLibraryCryptography = "EnterpriseLibraryCryptography";
			public const string LogName = "LogName";
			public const string MachineName = "MachineName";
			public const string FailureLogSource = "FailureLogSource";
			public const string LineSeperator = "LineSeperator";
			public const string WmiEventFailure = "WmiEventFailure";
			public const string DefaultInstanceName = "DefaultInstanceName";
			public const string GlobalInstanceName = "GlobalInstanceName";
			public const string AppSettingApplicationName = "AppSettingApplicationName";
			public const string ExceptionType = "ExceptionType";
		}


	}
}
