using System;

namespace SimpleCodingAssignmentsWebApp.Utilities
{
    public static class GeneralUtilities
    {
        public static bool EvaluateForPalindrome(string v)
        {
            int startIndex = 0;
            int endIndex = v.Length - 1;

            while (startIndex <= endIndex)
            {
                string firstChar = v.Substring(startIndex, 1);
                string lastChar = v.Substring(endIndex, 1);

                if (DoEndCharactersMatch(firstChar, lastChar))
                {
                    startIndex++;
                    endIndex--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private static bool DoEndCharactersMatch(string firstChar, string lastChar)
        {
            return (String.Compare(firstChar, lastChar) == 0);
        }
    }
}