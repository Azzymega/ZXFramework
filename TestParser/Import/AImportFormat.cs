using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QWFramework.Import
{
    public abstract class AImportFormat
    {
        protected string? output;
        protected string importPath;
        protected IImporter? importer;
        public AImportFormat(string importPath)
        {
            this.importPath = importPath;
        }
        protected abstract void Load();
        public string? ReturnOutput()
        {
            return output;
        }
    }
}
