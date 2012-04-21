 //===============================================================================
// Microsoft patterns & practices Enterprise Library
// Configuration Application Block
//===============================================================================
// Copyright � Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

#if UNIT_TESTS

namespace Microsoft.Practices.EnterpriseLibrary.Configuration.Tests
{
    public class ConfigurationData
    {
        private int size;
        private string color;
        private string someText;

        public ConfigurationData()
        {
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string SomeText
        {
            get { return someText; }
            set { someText = value; }
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }
    }
}

#endif