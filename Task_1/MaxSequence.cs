using System;

namespace Task_1
{
    /// <summary>
    ///  This class contains the method for counting the maximum number of identical consecutive elements in a string
    /// </summary>
    class MaxSequence
    {
        public string inputString;
        public MaxSequence(string maxSequence)
        {
            inputString = maxSequence;
        }

        /// <summary>
        /// Method for counting the maximum number of identical consecutive elements in a string
        /// </summary>
        /// <param name="str">string for processing</param>
        /// <returns> The maximum number of identical consecutive elements in a string </returns>
        public int CalculateMaxNumber()
        {

            int counterOfChars = 1;
            int maxSequence = 0;
            for (int i = 0; i < inputString.Length - 1; i++)
            {
                if (inputString[i] == inputString[i + 1])
                {
                    counterOfChars++;
                }
                else
                {
                    if (counterOfChars > maxSequence)
                    {
                        maxSequence = counterOfChars;
                    }
                    counterOfChars = 1;
                }
            }
            if (counterOfChars > maxSequence)
            {
                maxSequence = counterOfChars;
            }
            return maxSequence;
        } 
     }
}



   