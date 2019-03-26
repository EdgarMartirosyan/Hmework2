using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_03_04
{
    class DocumentWorker
    {
        public  void OpenDocument()
        {
            Console.WriteLine("The document is opened");
        }
        public virtual void EdithDocument()
        {
            Console.WriteLine("pastatuxty xmbagrel hnaravor e miayn PRO tarberakum");
        }
        public virtual void SaveDocumnet()
        {
            Console.WriteLine("pastatuxty pahpanel hnaravor e miayn PRO tarberakum");
        }
    }
}
