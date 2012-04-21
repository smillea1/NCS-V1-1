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

using System.Reflection;
using System.Security.Permissions;
using Microsoft.Practices.EnterpriseLibrary.Configuration.Design;
using Microsoft.Practices.EnterpriseLibrary.Security.Cache.CachingStore.Configuration.Design;
[assembly : ReflectionPermission(SecurityAction.RequestMinimum, MemberAccess=true)]
[assembly : ConfigurationDesignManager(typeof(SecurityCacheCachingStoreConfigurationDesignManager))]
[assembly : AssemblyTitle("Enterprise Library Security Caching Store Provider Design")]
[assembly : AssemblyDescription("")]
[assembly : AssemblyDelaySign(false)]
[assembly : AssemblyKeyFile("")]
[assembly : AssemblyKeyName("")]