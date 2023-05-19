using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace QWFramework.Export
{
    public class XLSX : AExportFormat
    {
        public XLSX(string filepath, string output) : base(filepath, output)
        {
            
        }
        protected override void Write()
        {
            writer.Close();
            XLWorkbook xLWorkbook = new XLWorkbook();
            IXLWorksheet worksheet = xLWorkbook.AddWorksheet("Sheet1");
            worksheet.Cell("A1").Value = new string(data);
            xLWorkbook.SaveAs(path);
        }
    }
}
