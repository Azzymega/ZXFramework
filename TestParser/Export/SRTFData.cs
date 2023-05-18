using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QWFramework.Export
{
    internal struct SRTFData
    {
        public string startEncoding;
        public string endEncoding;
        public SRTFData()
        {
            startEncoding = @"{\rtf1";
            endEncoding = "}";
        }
    }
}
