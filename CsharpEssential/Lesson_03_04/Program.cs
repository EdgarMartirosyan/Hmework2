
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_03_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("greq hampatsaxan bary");
            string key = Console.ReadLine();
            DocumentWorker doc = null;

            switch (key)
            {
                case "pro":doc = new ProDocumentWorker();
                    break;
                case "exp":doc=new ExpertDocumentWorker();
                    break;
                default: doc = new DocumentWorker();
                    return;
            }

            doc.OpenDocument();
            doc.EdithDocument();
            doc.SaveDocumnet();
            
            Console.ReadKey();
        }
    }
}
