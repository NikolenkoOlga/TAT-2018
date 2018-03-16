using System.Text;
using System;

namespace Task_2
{
    /// <summary>
    /// This class is searching for  and outputs  symbols the original strings with even indices.
    /// </summary>
    public class OutputEvenIndex
    {
        public string inputString;

        public OutputEvenIndex(string value)
        {
            inputString = value;
        }

        /// <summary>
        /// This method delete and print even indices.
        /// </summary>
        public string DeleteAndPrintEvenIndex()
        {
            StringBuilder evenIndex = new StringBuilder(inputString);           
            if (inputString.Length == 0)
            {
                Console.WriteLine("Empty string");
                return null;
            }

            for (int i = 1; i < evenIndex.Length; i += 1)
            {
                evenIndex.Remove(i, 1);
                inputString = evenIndex.ToString();
            }

            return inputString;
        }
    }
}
