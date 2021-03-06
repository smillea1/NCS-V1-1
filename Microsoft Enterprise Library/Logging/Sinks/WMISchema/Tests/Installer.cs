//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Logging and Instrumentation Application Block
//===============================================================================
// Copyright � Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

#if UNIT_TESTS

using System.ComponentModel;
using System.Management.Instrumentation;
[assembly : Instrumented(@"root\EnterpriseLibrary")]

namespace Microsoft.Practices.EnterpriseLibrary.Logging.Sinks.WMISchema.Tests.Tests
{
    [DesignerCategory("Code")]
    [RunInstaller(true)]
    public class Installer : DefaultManagementProjectInstaller
    {
        public Installer()
        {
        }
    }
}

#endif