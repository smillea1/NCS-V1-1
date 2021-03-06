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

#if  UNIT_TESTS

namespace Microsoft.Practices.EnterpriseLibrary.Logging.Formatters.Tests
{
    public class CustomToken : TokenFunction
    {
        public CustomToken() : base("[[AcmeDBLookup{", "}]]")
        {
        }

        public override string FormatToken(string tokenTemplate, LogEntry log)
        {
            return "1234";
        }
    }
}

#endif