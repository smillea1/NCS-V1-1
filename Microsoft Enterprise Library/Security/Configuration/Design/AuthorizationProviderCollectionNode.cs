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
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Configuration.Design;

namespace Microsoft.Practices.EnterpriseLibrary.Security.Configuration.Design
{
    /// <summary>
    /// The design time representation of the runtime configuration data
    /// for an authentication provider.
    /// </summary>
    [Image(typeof(AuthorizationProviderCollectionNode))]
    public class AuthorizationProviderCollectionNode : ConfigurationNode
    {
        private AuthorizationProviderDataCollection authorizationProviderDataCollection;

        /// <summary>
        /// Initializes a new instance of the 
        /// <see cref="AuthorizationProviderCollectionNode"/> class.
        /// </summary>
        public AuthorizationProviderCollectionNode() : this(new AuthorizationProviderDataCollection())
        {
        }

        /// <summary>
        /// Initializes a new instance of the 
        /// <see cref="AuthorizationProviderCollectionNode"/>
        /// class from the specified data.
        /// </summary>
        /// <param name="authorizationProviderDataCollection">The configuration data for an authentication provider collection.</param>
        public AuthorizationProviderCollectionNode(AuthorizationProviderDataCollection authorizationProviderDataCollection) : base()
        {
            if (authorizationProviderDataCollection == null)
            {
                throw new ArgumentNullException("authorizationProviderDataCollection");
            }
            this.authorizationProviderDataCollection = authorizationProviderDataCollection;
        }

        /// <summary>
        /// <para>Gets or sets the name for the node.</para>
        /// </summary>
        /// <value>
        /// <para>The display name for the node.</para>
        /// </value>
        [ReadOnly(true)]
        public override string Name
        {
            get { return base.Name; }
            set { base.Name = value; }
        }

        /// <summary>
        /// Retrieves configuration data based on the current state of the node.
        /// </summary>
        /// <returns>Configuration data for this node.</returns>
        [Browsable(false)]
        public virtual AuthorizationProviderDataCollection AuthorizationProviderDataCollection
        {
            get
            {
                authorizationProviderDataCollection.Clear();
                foreach (AuthorizationProviderNode node in this.Nodes)
                {
                    authorizationProviderDataCollection[node.AuthorizationProviderData.Name] = node.AuthorizationProviderData;
                }
                return authorizationProviderDataCollection;
            }
        }

        /// <summary>
        /// <para>Sets the name of the node and creates all the <see cref="AuthorizationProviderNode"/> objects based on the configuration data.</para>
        /// </summary>
        protected override void OnSited()
        {
            base.OnSited();
            Site.Name = SR.AuthorizationProviderCollectionNodeName;
            CreateDynamicNodes(authorizationProviderDataCollection);
        }

        /// <summary>
        /// <para>Add a menu item for the <see cref="ValidateNodeCommand"/> and the menu items to create registered <see cref="AuthorizationProviderNode"/> objects.</para>
        /// </summary>
        protected override void OnAddMenuItems()
        {
            ConfigurationMenuItem.CreateValidateNodeCommand(Site, this);
            CreateDynamicMenuItems(typeof(AuthorizationProviderNode));
        }
    }
}