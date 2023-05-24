using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QWFramework.Export
{
    public class RTFExporter : AExporter
    {
        public RTFExporter(BinaryWriter Writer) : base(Writer)
        {

        }
        public override void Write(string Data)
        {
            this.Writer.Write(Data);
        }
    }
}
