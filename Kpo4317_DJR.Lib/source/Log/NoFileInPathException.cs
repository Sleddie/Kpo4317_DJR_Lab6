using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4317_DJR.Lib
{
    class NoFileInPathException : Exception
    {
        public NoFileInPathException () : base("Искомый файл не найден")
        {

        }
    }
}
