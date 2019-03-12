using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsSophisticatedLesson
{
    public class Stanger : IManager
    {
        public void DoManagerWork()
        {
            Console.WriteLine("Какой-то левый чувак  делает какую-то левую менеджерскую работу");
        }
    }
}
