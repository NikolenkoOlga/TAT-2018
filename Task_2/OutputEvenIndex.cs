using System.Text;
using System;

namespace Task_2
{
    /// <summary>
    /// This class is searching for  and outputs  symbols the original strings with even indices.
    /// </summary>
    class OutputEvenIndex
    {
        private string inputString;
   
        public OutputEvenIndex(string value)
        {
            inputString = value;
        }
        /// <summary>
        /// This method outputs even indices.
        /// </summary>
        public void FindEvenIndex()
        {
            StringBuilder EvenIndex = new StringBuilder(inputString);

            if (inputString.Length == 0)
            {
                Console.WriteLine("Empty string");
            }

            for (int i = 1; i < EvenIndex.Length; i+=1)
            {
                EvenIndex.Remove(i, 1);
            }

            Console.WriteLine(EvenIndex);
        }
    }
}