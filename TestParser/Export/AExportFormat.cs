using System;
using System.Collections.Generic;
using System.Text;

namespace QWFramework.Export
{
    public abstract class AExportFormat
    {
        private string FilePath;
        private string FileName;
        private string Output;
        private AExporter Exporter;
        public AExportFormat(string FilePath, string FileName, AExporter Exporter) 
        {
            this.FilePath = FilePath;
            this.FileName = FileName;
            this.Exporter = Exporter;
            Exporter.Write(Output);
        }
    }
}
