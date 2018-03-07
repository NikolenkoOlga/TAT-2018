using System;
using System.Text;

namespace Task_2
{
    class EntryPoint
    {
        static void Main()
        {
            OutputEvenIndex inputString = new OutputEvenIndex(Console.ReadLine());
            inputString.FindEvenIndex();   
        }
    }
}
