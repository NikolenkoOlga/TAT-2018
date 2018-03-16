using System;
using System.Text;

namespace Task_2
{
    class EntryPoint
    {
        static void Main()
        {
            string inputString = Console.ReadLine();
            OutputEvenIndex outputString = new OutputEvenIndex(inputString);
            Console.WriteLine(outputString.DeleteEvenIndex());
            Console.ReadKey();
        }
    }
}
