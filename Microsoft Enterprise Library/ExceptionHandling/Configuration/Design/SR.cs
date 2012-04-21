// WARNING:
// This file generated by the Microsoft DataWarehouse String Resource Tool 1.13.5000.0
// from information in SR.strings.   
// DO NO MODIFY THIS FILE'S CONTENTS, THEY WILL BE OVERWRITTEN
//
namespace Microsoft.Practices.EnterpriseLibrary.ExceptionHandling.Configuration.Design
{
	using System;
	using System.Resources;
	using System.Globalization;

	internal class SR
	{
		public static string CategoryGeneral
		{
			get { return Keys.GetString( Keys.CategoryGeneral ); }
		}
		public static string DefaultExceptionPolicyNodeName
		{
			get { return Keys.GetString( Keys.DefaultExceptionPolicyNodeName ); }
		}
		public static string DefaultExceptionTypeNodeName
		{
			get { return Keys.GetString( Keys.DefaultExceptionTypeNodeName ); }
		}
		public static string DefaultExceptionHandlingSettingsNodeName
		{
			get { return Keys.GetString( Keys.DefaultExceptionHandlingSettingsNodeName ); }
		}
		public static string DefaultWrapHandlerNodeName
		{
			get { return Keys.GetString( Keys.DefaultWrapHandlerNodeName ); }
		}
		public static string DefaultReplaceHandlerNodeName
		{
			get { return Keys.GetString( Keys.DefaultReplaceHandlerNodeName ); }
		}
		public static string DefaultCustomHandlerNodeName
		{
			get { return Keys.GetString( Keys.DefaultCustomHandlerNodeName ); }
		}
		public static string SelectTypeDialogCaption
		{
			get { return Keys.GetString( Keys.SelectTypeDialogCaption ); }
		}
		public static string DuplicateExceptionTypeErrorMessage (string exceptionTypeName)
		{
			return Keys.GetString( Keys.DuplicateExceptionTypeErrorMessage, exceptionTypeName );
		}
		public static string ExceptionTypeNodeNameDescription
		{
			get { return Keys.GetString( Keys.ExceptionTypeNodeNameDescription ); }
		}
		public static string WrapHandlerNodeMessageDescription
		{
			get { return Keys.GetString( Keys.WrapHandlerNodeMessageDescription ); }
		}
		public static string ExceptionReplaceMessageDescription
		{
			get { return Keys.GetString( Keys.ExceptionReplaceMessageDescription ); }
		}
		public static string ExceptionWrapTypeNameDescription
		{
			get { return Keys.GetString( Keys.ExceptionWrapTypeNameDescription ); }
		}
		public static string ExceptionReplaceTypeNameDescription
		{
			get { return Keys.GetString( Keys.ExceptionReplaceTypeNameDescription ); }
		}
		public static string ExceptionTypePostHandlingActionDescription
		{
			get { return Keys.GetString( Keys.ExceptionTypePostHandlingActionDescription ); }
		}
		public static string ExceptionHandlerNameDescription
		{
			get { return Keys.GetString( Keys.ExceptionHandlerNameDescription ); }
		}
		public static string ExceptionHandlerTypeDescription
		{
			get { return Keys.GetString( Keys.ExceptionHandlerTypeDescription ); }
		}
		public static string ExceptionHandlerAdditionalPropertiesDescription
		{
			get { return Keys.GetString( Keys.ExceptionHandlerAdditionalPropertiesDescription ); }
		}
		public static string ExceptionHandlingSettingsNodeMenuText
		{
			get { return Keys.GetString( Keys.ExceptionHandlingSettingsNodeMenuText ); }
		}
		public static string ExceptionPolicyNodeMenuText
		{
			get { return Keys.GetString( Keys.ExceptionPolicyNodeMenuText ); }
		}
		public static string ExceptionTypeNodeMenuText
		{
			get { return Keys.GetString( Keys.ExceptionTypeNodeMenuText ); }
		}
		public static string MoveUpMenuItemText
		{
			get { return Keys.GetString( Keys.MoveUpMenuItemText ); }
		}
		public static string MoveDownMenuItemText
		{
			get { return Keys.GetString( Keys.MoveDownMenuItemText ); }
		}
		public static string GenericCreateStatusText (string name)
		{
			return Keys.GetString( Keys.GenericCreateStatusText, name );
		}
		public static string ExceptionTypeNodeStatusText
		{
			get { return Keys.GetString( Keys.ExceptionTypeNodeStatusText ); }
		}
		public static string ExceptionPolicyNodeStatusText
		{
			get { return Keys.GetString( Keys.ExceptionPolicyNodeStatusText ); }
		}
		public static string ExceptionHandlingSettingsNodeStatusText
		{
			get { return Keys.GetString( Keys.ExceptionHandlingSettingsNodeStatusText ); }
		}
		public static string MoveUpStatusText
		{
			get { return Keys.GetString( Keys.MoveUpStatusText ); }
		}
		public static string MoveDownStatusText
		{
			get { return Keys.GetString( Keys.MoveDownStatusText ); }
		}

		internal class Keys 
		{
			static ResourceManager resourceManager = 
				new ResourceManager("Microsoft.Practices.EnterpriseLibrary.ExceptionHandling.Configuration.Design.SR", typeof(Microsoft.Practices.EnterpriseLibrary.ExceptionHandling.Configuration.Design.SR).Module.Assembly );

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

			public const string CategoryGeneral = "CategoryGeneral";
			public const string DefaultExceptionPolicyNodeName = "DefaultExceptionPolicyNodeName";
			public const string DefaultExceptionTypeNodeName = "DefaultExceptionTypeNodeName";
			public const string DefaultExceptionHandlingSettingsNodeName = "DefaultExceptionHandlingSettingsNodeName";
			public const string DefaultWrapHandlerNodeName = "DefaultWrapHandlerNodeName";
			public const string DefaultReplaceHandlerNodeName = "DefaultReplaceHandlerNodeName";
			public const string DefaultCustomHandlerNodeName = "DefaultCustomHandlerNodeName";
			public const string SelectTypeDialogCaption = "SelectTypeDialogCaption";
			public const string DuplicateExceptionTypeErrorMessage = "DuplicateExceptionTypeErrorMessage";
			public const string ExceptionTypeNodeNameDescription = "ExceptionTypeNodeNameDescription";
			public const string WrapHandlerNodeMessageDescription = "WrapHandlerNodeMessageDescription";
			public const string ExceptionReplaceMessageDescription = "ExceptionReplaceMessageDescription";
			public const string ExceptionWrapTypeNameDescription = "ExceptionWrapTypeNameDescription";
			public const string ExceptionReplaceTypeNameDescription = "ExceptionReplaceTypeNameDescription";
			public const string ExceptionTypePostHandlingActionDescription = "ExceptionTypePostHandlingActionDescription";
			public const string ExceptionHandlerNameDescription = "ExceptionHandlerNameDescription";
			public const string ExceptionHandlerTypeDescription = "ExceptionHandlerTypeDescription";
			public const string ExceptionHandlerAdditionalPropertiesDescription = "ExceptionHandlerAdditionalPropertiesDescription";
			public const string ExceptionHandlingSettingsNodeMenuText = "ExceptionHandlingSettingsNodeMenuText";
			public const string ExceptionPolicyNodeMenuText = "ExceptionPolicyNodeMenuText";
			public const string ExceptionTypeNodeMenuText = "ExceptionTypeNodeMenuText";
			public const string MoveUpMenuItemText = "MoveUpMenuItemText";
			public const string MoveDownMenuItemText = "MoveDownMenuItemText";
			public const string GenericCreateStatusText = "GenericCreateStatusText";
			public const string ExceptionTypeNodeStatusText = "ExceptionTypeNodeStatusText";
			public const string ExceptionPolicyNodeStatusText = "ExceptionPolicyNodeStatusText";
			public const string ExceptionHandlingSettingsNodeStatusText = "ExceptionHandlingSettingsNodeStatusText";
			public const string MoveUpStatusText = "MoveUpStatusText";
			public const string MoveDownStatusText = "MoveDownStatusText";
		}


	}
}
