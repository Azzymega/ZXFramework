using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QWFramework.Export
{
    public class CSV : AExportFormat
    {
        public CSV(string filepath, string output) : base(filepath, output)
        {

        }
        protected override void Write()
        {
            writer.Write(data);
            writer.Close();
        }
    }
}
