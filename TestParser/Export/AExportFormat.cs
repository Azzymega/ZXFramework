using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QWFramework.Export
{
    public abstract class AExportFormat
    {
        protected BinaryWriter writer;
        protected char[] data;
        public AExportFormat(string filepath, string output)
        {
            writer = new BinaryWriter(File.Open(filepath, FileMode.OpenOrCreate));
            data = output.ToCharArray();
            Write();
        }
        protected abstract void Write();
    }
}
