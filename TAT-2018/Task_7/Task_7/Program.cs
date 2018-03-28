using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory dev = new Mazda("ООО КирпичСтрой");
            Car house2 = dev.Create();

            dev = new WoodDeveloper("Частный застройщик");
            Car house = dev.Create();

            System.Console.ReadLine();
        }
    }
}

  
