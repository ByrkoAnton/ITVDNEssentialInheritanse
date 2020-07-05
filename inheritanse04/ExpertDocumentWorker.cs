using System;
using System.Collections.Generic;
using System.Text;

namespace inheritanse04
{
    class ExpertDocumentWorker:ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("\"Документ сохранен в новом формате\"");
        }
    }
}
