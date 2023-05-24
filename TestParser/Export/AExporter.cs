using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QWFramework.Export
{
    public abstract class AExporter
    {
        protected BinaryWriter Writer;
        public AExporter(BinaryWriter Writer)
        {
            this.Writer = Writer;
        }
        public abstract void Write(string Data);
    }
}
