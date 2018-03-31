using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  CarFactory dev = new Mazda("");
              Car house2 = dev.Create();        
              System.Console.ReadLine(); */

            void MenuActions()
            {
                bool notExit = true;
                int pointMenu;
                Console.WriteLine("Добавте новую машину на склад");
                while (notExit)
                {
                    Console.WriteLine("1 - Добавить машину" +
                                      "0 - exit");
                    pointMenu = int.Parse(Console.ReadLine());
                    switch (pointMenu)
                    {
                        case 1:
                            MenuAddCar();
                            break;
                        case 0:
                            notExit = false;
                            break;

                    }
                }
            }

            void MenuAddCar()
            {
                bool notExit = true;
                int pointMenu;
                Console.WriteLine("Выберете машину\n");
                while (notExit)
                {
                    Console.WriteLine("1 - Mazda\n" +
                                      "2 - Maskvich\n"+
                                      "3 - Opel\n"+
                                      "4 - Kia\n"+
                                      "0 - Exit\n");
                    pointMenu = int.Parse(Console.ReadLine());
                    CarFactory carFactory = null;
                    switch (pointMenu)
                    {
                        case 1:
                            carFactory = new MazdaFactory();                            
                            break;
                        case 2:
                            carFactory = new MoskvichFactory();
                            ;
                            break;
                        case 3:
                            carFactory = new OpelFactory(); 
                            break;
                        case 4:
                            carFactory = new KiaFactory();
                            break;                        
                        case 0:
                            notExit = false;
                            break;

                    }
                }
            }
        }
    }
}
