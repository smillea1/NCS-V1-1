//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Cryptography Application Block
//===============================================================================
// Copyright � Microsoft Corporation. All rights reserved.
// Adapted from ACA.NET with permission from Avanade Inc.
// ACA.NET copyright � Avanade Inc. All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using System.Management.Instrumentation;
using Microsoft.Practices.EnterpriseLibrary.Common.Instrumentation;
[assembly : Instrumented(@"root\EnterpriseLibrary")]

namespace Microsoft.Practices.EnterpriseLibrary.Security.Cryptography.Instrumentation
{
    /// <summary>
    /// <para>
    /// This type supports the Instrumentation infrastructure and is not intended to be used directly from your code.
    /// </para>
    /// </summary>
    [System.ComponentModel.DesignerCategory("Code")]
    public class ProjectInstaller : ProjectInstallerBase
    {
        /// <summary/>
        /// <exclude/>
        public ProjectInstaller()
            : base(SR.InstrumentationEventSource,
                   SR.InstrumentationCounterCategory,
                   SR.InstrumentationCounterCategoryHelp,
                   SecurityCryptoServiceEvent.Counters)
        {
        }
    }
}