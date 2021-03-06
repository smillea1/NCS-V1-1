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
[assembly : ReflectionPermission(SecurityAction.RequestMinimum, MemberAccess=true)]
[assembly : AssemblyTitle("Enterprise Library Security Active Directory Provider")]
[assembly : AssemblyDescription("Provider implementations using Active Directory as the backing store.")]
[assembly : AssemblyDelaySign(false)]
[assembly : AssemblyKeyFile("")]
[assembly : AssemblyKeyName("")]