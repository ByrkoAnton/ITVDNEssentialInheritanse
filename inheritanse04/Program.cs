using System;

namespace inheritanse04
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker documentWorker = new DocumentWorker();

            Console.Write("enter key ");
            string key = Console.ReadLine();

            if (key == "pro")
                documentWorker = new ProDocumentWorker();

            else if (key == "exp")
                documentWorker = new ExpertDocumentWorker();

            documentWorker.OpenDocument();
            documentWorker.EditDocument();
            documentWorker.SaveDocument();
        }
    }
}
