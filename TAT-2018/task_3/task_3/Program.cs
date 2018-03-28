using System;
using System.Text;

namespace task_DEV_3
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            if (!(args.Length == 2))
            {
                Console.WriteLine("Error! Incorrect format of the data!");
                return;
            }

            long inputNumber;
            int namberOfNewSystem;

            bool checkNumber = Int64.TryParse(args[0], out inputNumber);
            bool checkFormatBase = Int32.TryParse(args[1], out namberOfNewSystem);
            bool checkIntervalBase = namberOfNewSystem > 2 && namberOfNewSystem < 20;

            if (checkNumber && checkFormatBase && checkIntervalBase)
            {
                ConverterToAnotherSystem converter = new ConverterToAnotherSystem(namberOfNewSystem);
                Console.WriteLine(converter.GetConvertNumber(inputNumber));
            }
            else
            {
                Console.WriteLine("Error! Incorrect format of the data!");
               
            }
        }
    }
}
