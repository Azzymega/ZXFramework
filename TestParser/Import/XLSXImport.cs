using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QWFramework.Import
{
    public class XLSXImport : AImportFormat
    {
        public XLSXImport(string filepath) : base(filepath)
        {
            importer = new XLSXImporter();
            Load();

        }
        protected override void Load()
        {
            importer.Import(importPath);
            output = importer.ReturnOutput();
        }
    }
}
