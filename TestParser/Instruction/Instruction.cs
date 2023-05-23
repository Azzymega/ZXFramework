using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QWFramework.Instruction
{
    public static class Instruction
    {
        public static string ReturnInstructionText()
        {
            return "Для обозначения степени использовать - ^.\nОперации с косинусом или синусом пишутся в скобках - sin(3x).\nВыгрузка в текстовый редактор производится в формате RTF.\nВыгрузка в табличный процессор производится в формате XLSX.\nЗагрузка через табличный процессор производится в формате XLSX.\nВвод символов, не относящихся к решению интеграла необходимо выполнять целыми или дробными числами с применением знака '/'.\nПри загрузке через табличный процессор уравнение должно находится в ячейке A1.\nПеременной интеграла может быть только X";
        }
    }
}
