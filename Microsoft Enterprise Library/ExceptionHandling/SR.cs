// WARNING:
// This file generated by the Microsoft DataWarehouse String Resource Tool 1.13.5000.0
// from information in SR.strings.   
// DO NO MODIFY THIS FILE'S CONTENTS, THEY WILL BE OVERWRITTEN
//
namespace Microsoft.Practices.EnterpriseLibrary.ExceptionHandling
{
	using System;
	using System.Resources;
	using System.Globalization;

	internal class SR
	{
		public static string HandlerFactoryName
		{
			get { return Keys.GetString( Keys.HandlerFactoryName ); }
		}
		public static string PolicyFactoryName
		{
			get { return Keys.GetString( Keys.PolicyFactoryName ); }
		}
		public static string PermissionDenied
		{
			get { return Keys.GetString( Keys.PermissionDenied ); }
		}
		public static string UnknownReadError
		{
			get { return Keys.GetString( Keys.UnknownReadError ); }
		}
		public static string UnableToLoadExceptionHandlers (string exceptionTypeName, string policyName)
		{
			return Keys.GetString( Keys.UnableToLoadExceptionHandlers, exceptionTypeName, policyName );
		}
		public static string UnableToHandleException (string handlerName)
		{
			return Keys.GetString( Keys.UnableToHandleException, handlerName );
		}
		public static string ExceptionWasCaught (string typeName)
		{
			return Keys.GetString( Keys.ExceptionWasCaught, typeName );
		}
		public static string StackTraceUnavailable
		{
			get { return Keys.GetString( Keys.StackTraceUnavailable ); }
		}
		public static string UndefinedValue
		{
			get { return Keys.GetString( Keys.UndefinedValue ); }
		}
		public static string AdditionalInfo
		{
			get { return Keys.GetString( Keys.AdditionalInfo ); }
		}
		public static string OffendingException
		{
			get { return Keys.GetString( Keys.OffendingException ); }
		}
		public static string OriginalException
		{
			get { return Keys.GetString( Keys.OriginalException ); }
		}
		public static string ChainException
		{
			get { return Keys.GetString( Keys.ChainException ); }
		}
		public static string PolicyName (string policyName)
		{
			return Keys.GetString( Keys.PolicyName, policyName );
		}
		public static string Message
		{
			get { return Keys.GetString( Keys.Message ); }
		}
		public static string Source
		{
			get { return Keys.GetString( Keys.Source ); }
		}
		public static string ExceptionString
		{
			get { return Keys.GetString( Keys.ExceptionString ); }
		}
		public static string StackTrace
		{
			get { return Keys.GetString( Keys.StackTrace ); }
		}
		public static string HelpLink
		{
			get { return Keys.GetString( Keys.HelpLink ); }
		}
		public static string TypeString
		{
			get { return Keys.GetString( Keys.TypeString ); }
		}
		public static string InnerException
		{
			get { return Keys.GetString( Keys.InnerException ); }
		}
		public static string ExceptionExceptionTypeDataName
		{
			get { return Keys.GetString( Keys.ExceptionExceptionTypeDataName ); }
		}
		public static string ExceptionNullException
		{
			get { return Keys.GetString( Keys.ExceptionNullException ); }
		}
		public static string ExceptionUnableToWrapException (string typeName)
		{
			return Keys.GetString( Keys.ExceptionUnableToWrapException, typeName );
		}
		public static string ExceptionUnableToReplaceException (string typeName)
		{
			return Keys.GetString( Keys.ExceptionUnableToReplaceException, typeName );
		}
		public static string ExceptionSimpleProviderNotFound (string policyName)
		{
			return Keys.GetString( Keys.ExceptionSimpleProviderNotFound, policyName );
		}
		public static string ExceptionExtendedProviderNotFound (string policyName, string exceptionMessage)
		{
			return Keys.GetString( Keys.ExceptionExtendedProviderNotFound, policyName, exceptionMessage );
		}
		public static string ExceptionNoPoliciesDefined
		{
			get { return Keys.GetString( Keys.ExceptionNoPoliciesDefined ); }
		}
		public static string ExceptionNoExceptionTypesForPolicy (string policyName)
		{
			return Keys.GetString( Keys.ExceptionNoExceptionTypesForPolicy, policyName );
		}
		public static string ExceptionExceptionTypeNotFound (string exceptionType, string policyName)
		{
			return Keys.GetString( Keys.ExceptionExceptionTypeNotFound, exceptionType, policyName );
		}
		public static string ExceptionNoExceptionHandlerForType (string exceptionTypeName, string policyName)
		{
			return Keys.GetString( Keys.ExceptionNoExceptionHandlerForType, exceptionTypeName, policyName );
		}
		public static string ExceptionExceptionHanlderNotFoun (string handlerName, string exceptionTypeName, string policyName)
		{
			return Keys.GetString( Keys.ExceptionExceptionHanlderNotFoun, handlerName, exceptionTypeName, policyName );
		}
		public static string ExceptionUnknownExceptionTypeInConfiguration (string exceptionTypeName)
		{
			return Keys.GetString( Keys.ExceptionUnknownExceptionTypeInConfiguration, exceptionTypeName );
		}
		public static string InstrumentationCounterCategoryHelp
		{
			get { return Keys.GetString( Keys.InstrumentationCounterCategoryHelp ); }
		}
		public static string PerfCounterExceptionsHandledMsg
		{
			get { return Keys.GetString( Keys.PerfCounterExceptionsHandledMsg ); }
		}
		public static string PerfCounterExceptionsUnhandledMsg
		{
			get { return Keys.GetString( Keys.PerfCounterExceptionsUnhandledMsg ); }
		}
		public static string EntLibExceptionHandlerSource
		{
			get { return Keys.GetString( Keys.EntLibExceptionHandlerSource ); }
		}

		internal class Keys 
		{
			static ResourceManager resourceManager = 
				new ResourceManager("Microsoft.Practices.EnterpriseLibrary.ExceptionHandling.SR", typeof(Microsoft.Practices.EnterpriseLibrary.ExceptionHandling.SR).Module.Assembly );

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

			public const string HandlerFactoryName = "HandlerFactoryName";
			public const string PolicyFactoryName = "PolicyFactoryName";
			public const string PermissionDenied = "PermissionDenied";
			public const string UnknownReadError = "UnknownReadError";
			public const string UnableToLoadExceptionHandlers = "UnableToLoadExceptionHandlers";
			public const string UnableToHandleException = "UnableToHandleException";
			public const string ExceptionWasCaught = "ExceptionWasCaught";
			public const string StackTraceUnavailable = "StackTraceUnavailable";
			public const string UndefinedValue = "UndefinedValue";
			public const string AdditionalInfo = "AdditionalInfo";
			public const string OffendingException = "OffendingException";
			public const string OriginalException = "OriginalException";
			public const string ChainException = "ChainException";
			public const string PolicyName = "PolicyName";
			public const string Message = "Message";
			public const string Source = "Source";
			public const string ExceptionString = "ExceptionString";
			public const string StackTrace = "StackTrace";
			public const string HelpLink = "HelpLink";
			public const string TypeString = "TypeString";
			public const string InnerException = "InnerException";
			public const string ExceptionExceptionTypeDataName = "ExceptionExceptionTypeDataName";
			public const string ExceptionNullException = "ExceptionNullException";
			public const string ExceptionUnableToWrapException = "ExceptionUnableToWrapException";
			public const string ExceptionUnableToReplaceException = "ExceptionUnableToReplaceException";
			public const string ExceptionSimpleProviderNotFound = "ExceptionSimpleProviderNotFound";
			public const string ExceptionExtendedProviderNotFound = "ExceptionExtendedProviderNotFound";
			public const string ExceptionNoPoliciesDefined = "ExceptionNoPoliciesDefined";
			public const string ExceptionNoExceptionTypesForPolicy = "ExceptionNoExceptionTypesForPolicy";
			public const string ExceptionExceptionTypeNotFound = "ExceptionExceptionTypeNotFound";
			public const string ExceptionNoExceptionHandlerForType = "ExceptionNoExceptionHandlerForType";
			public const string ExceptionExceptionHanlderNotFoun = "ExceptionExceptionHanlderNotFoun";
			public const string ExceptionUnknownExceptionTypeInConfiguration = "ExceptionUnknownExceptionTypeInConfiguration";
			public const string InstrumentationCounterCategoryHelp = "InstrumentationCounterCategoryHelp";
			public const string PerfCounterExceptionsHandledMsg = "PerfCounterExceptionsHandledMsg";
			public const string PerfCounterExceptionsUnhandledMsg = "PerfCounterExceptionsUnhandledMsg";
			public const string EntLibExceptionHandlerSource = "EntLibExceptionHandlerSource";
		}


	}
}