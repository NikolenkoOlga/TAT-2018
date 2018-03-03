using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Entry
    {
        static void Main(string[] args)
        {
            if (args.Length >= 1)
            {
                MaxSequence maxSequense = new MaxSequence(args[0]);
                int maxCount = maxSequense.CalculateMaxNumber();
                Console.WriteLine("Maximum sequence of chars in string = {0}", maxCount);
            }
            else
            {
                Console.WriteLine("The string wasn't entered");
            }
        }  
   }
 }
