using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QWFramework.Export
{
    public class RTF : AExportFormat
    {
        private SRTFData exportFormatData;
        public RTF(string filepath, string output) : base(filepath,output) 
        {
            
        }
        protected override void Write()
        {
            exportFormatData = new SRTFData();
            writer.Write(data);
            writer.Close();
        }
    }
}
