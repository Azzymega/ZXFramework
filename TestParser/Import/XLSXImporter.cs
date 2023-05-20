using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QWFramework.Import
{
    public class XLSXImporter : IImporter
    {
        private string? output;
        public void Import(string path)
        {
            XLWorkbook book = new XLWorkbook(path);
            IXLWorksheet sheet = book.Worksheet(1);
            output = sheet.Cell("A1").GetValue<string>();
        }
        public string ReturnOutput()
        {
            return output;
        }
    }
}
