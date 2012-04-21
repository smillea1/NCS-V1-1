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

using System;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Configuration.Design;
using Microsoft.Practices.EnterpriseLibrary.Security.Configuration;

namespace Microsoft.Practices.EnterpriseLibrary.Security.AzMan.Configuration.Design
{
    /// <summary>
    /// Configuration Design Manager for AzMan. <seealso cref="IConfigurationDesignManager"/>.
    /// </summary>
    public class SecurityAzManConfigurationDesignManager : IConfigurationDesignManager
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityAzManConfigurationDesignManager"/> class.
        /// </summary>
        public SecurityAzManConfigurationDesignManager()
        {
        }

        /// <summary>
        /// <para>Registers the <see cref="AzManAuthorizationProviderNode"/> in the application.</para>
        /// </summary>
        /// <param name="serviceProvider">
        /// <para>The a mechanism for retrieving a service object; that is, an object that provides custom support to other objects.</para>
        /// </param>
        public void Register(IServiceProvider serviceProvider)
        {
            RegisterNodeTypes(serviceProvider);
            RegisterXmlIncludeTypes(serviceProvider);
        }

        /// <summary>
        /// <para>Opens the configuration settings and registers them with the application.</para>
        /// </summary>
        /// <param name="serviceProvider">
        /// <para>The a mechanism for retrieving a service object; that is, an object that provides custom support to other objects.</para>
        /// </param>
        public void Open(IServiceProvider serviceProvider)
        {
        }

        /// <summary>
        /// <para>Saves the configuration settings created for the application.</para>
        /// </summary>
        /// <param name="serviceProvider">
        /// <para>The a mechanism for retrieving a service object; that is, an object that provides custom support to other objects.</para>
        /// </param>
        public void Save(IServiceProvider serviceProvider)
        {
        }

        /// <summary>
        /// <para>Adds to the dictionary configuration data for 
        /// the enterpriselibrary.configurationSettings configuration section.</para>
        /// </summary>
        /// <param name="serviceProvider">
        /// <para>The a mechanism for retrieving a service object; that is, an object that provides custom support to other objects.</para>
        /// </param>
        /// <param name="configurationDictionary">
        /// <para>A <see cref="ConfigurationDictionary"/> to add 
        /// configuration data to.</para></param>
        public void BuildContext(IServiceProvider serviceProvider, ConfigurationDictionary configurationDictionary)
        {
        }

        private static void RegisterXmlIncludeTypes(IServiceProvider serviceProvider)
        {
            IXmlIncludeTypeService xmlIncludeTypeService = serviceProvider.GetService(typeof(IXmlIncludeTypeService)) as IXmlIncludeTypeService;
            Debug.Assert(xmlIncludeTypeService != null, "Could not find the IXmlIncludeTypeService");
            xmlIncludeTypeService.AddXmlIncludeType(SecuritySettings.SectionName, typeof(AzManAuthorizationProviderData));
        }

        private static void RegisterNodeTypes(IServiceProvider serviceProvider)
        {
            INodeCreationService nodeCreationService = ServiceHelper.GetNodeCreationService(serviceProvider);

            Type nodeType = typeof(AzManAuthorizationProviderNode);
            NodeCreationEntry entry = NodeCreationEntry.CreateNodeCreationEntryWithMultiples(new AddChildNodeCommand(serviceProvider, nodeType), nodeType, typeof(AzManAuthorizationProviderData), SR.AzManProvider);
            nodeCreationService.AddNodeCreationEntry(entry);
        }
    }
}