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
        /// <returns> The maximum number of identical consecutive elements in a string </returns>
        public int CalculateMaxNumber()
        {
            int currentCount = 1;
            int maxCount = currentCount;
            for (int i = 1; i < inputString.Length; i++)
            {
                if (inputString[i - 1] == inputString[i])
                {
                    currentCount++;
                }
                else
                {
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                    currentCount = 1;
                }
            }
            if (currentCount > maxCount)
            {
                maxCount = currentCount;
            }
            return maxCount;
        } 
     }
}
