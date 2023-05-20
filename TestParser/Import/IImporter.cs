using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QWFramework.Import
{
    public interface IImporter
    {
        public abstract void Import(string path);
        public abstract string ReturnOutput();
    }
}
