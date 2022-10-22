using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    internal class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ відкритий");
        }
        public virtual void EditDocument() 
        {
            Console.WriteLine("Правка документа доступна у версії Про");
        }
        public virtual void SaveDocument() 
        {
            Console.WriteLine("Збереження документа доступне у версії Про");
        }
    }
}
