using System;
using System.Collections.Generic;
using System.Text;

namespace inheritanseAdditional
{
    class PrinterBase
    {
        public virtual void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
