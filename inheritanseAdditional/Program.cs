using System;

namespace inheritanseAdditional
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "print";
            PrinterBase printerBase = new PrinterBase();
            printerBase.Print(str);

            PinterChild pinterChild = new PinterChild();
            pinterChild.Print(str);

            printerBase = pinterChild;

            printerBase.Print(str);

            printerBase = new PrinterBase();
            printerBase.Print(str);
        }
    }
}
