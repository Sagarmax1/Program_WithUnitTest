using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_WithUnitTest
{
    public class DemoProgram
    {
        public int noOfFactorial(int num)
        {
            int factorial = 1;

            for (int i = 1; i <= num; i++)
                factorial = factorial * i;

            return factorial;
        }

        public bool isStringDuplicate(string[] array)
        {
            var duplicates = array
             .GroupBy(p => p)
             .Where(g => g.Count() > 1)
             .Select(g => g.Key);

            return (duplicates.Count() > 0);
        }

        public string removeDuplicateString(string str)
        {
            string finalString = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (!finalString.Contains(str[i]))
                {
                    finalString += str[i];
                }
            }
            return finalString;
        }

        public int noOfStringCharacterCount(string str)
        {
            int count = 0;
            foreach (var ch in str)
            {
                count++;
            }
            return count;
        }

        public bool numberIsPrime(int num)
        {
            int i;
            int m = 0;
            int flag = 0;
            m = num / 2;
            for (i = 2; i <= m; i++)
            {
                if (num % i == 0)
                {
                    flag = 1;
                    break;
                }
            }
            return flag == 0;
        }
    }
}
