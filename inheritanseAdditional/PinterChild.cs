using System;
using System.Collections.Generic;
using System.Text;

namespace inheritanseAdditional
{
    class PinterChild:PrinterBase
    {
        public override void Print(string str)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            base.Print(str);
            Console.ResetColor();
        }
    }
}
