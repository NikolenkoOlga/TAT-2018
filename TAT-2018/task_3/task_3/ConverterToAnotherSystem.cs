using System;
using System.Text;

namespace task_DEV_3
{
    /// <summary>
    /// This class converts the number in another numeral system.
    /// </summary>
    class ConverterToAnotherSystem
    {
        private int baseOfSystem;

        public ConverterToAnotherSystem(int valueBase)
        {
            baseOfSystem = valueBase;
        }

        /// <summary>
        /// This method converts one number into a number in the new system of calculus.
        /// </summary>
        /// <param name="inputNumber">the number to convert</param>
        /// <returns>the converted number</returns>
        public string GetConvertNumber(long inputNumber)
        {
            StringBuilder convertNumber = new StringBuilder();

            do
            {
                convertNumber.Insert(0, GetDigit((int)(inputNumber % baseOfSystem)));
                inputNumber /= baseOfSystem;
            }
            while (inputNumber > 0);

            return convertNumber.ToString();
        }

        private char GetDigit(int numberOfDigit)
        {
            string allDigits = "0123456789ABCDEFGHIJ";
            return allDigits[numberOfDigit];
        }
    }
}
