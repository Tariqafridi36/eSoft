using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CommonTask
    { 
        public int[] ReverseArray(int[] array)
        {
            Array.Reverse(array);
            return array;
        } 
        public static string IsPalindrome(string inputString)
        {
            Regex rgx = new Regex("[^a-zA-Z]");
            inputString = rgx.Replace(inputString, "");
            string secondString = ReverseString(inputString);
            return inputString == secondString ? "OK" : "NO";

        } 
        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static string Permutation(int[] m, int[] n)
        {
            Array.Sort(m);
            Array.Sort(n);

            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] != m[i])
                {
                    return "NO";
                }
            }
            return "YES";
        }

        public static string ExistingPowerOf2(int[] inputArr)
        {
            string resultString = "";

            List<int> result = new List<int>();

            for (int i = 0; i < inputArr.Count(); i++)
            {
                result.AddRange(powers_finder(inputArr[i]));
            }
            result.Sort();
            result = result.Distinct().ToList();
            result.ForEach(delegate (int item)
            {
                resultString += item + ",";
            });

            return resultString.TrimEnd(',');
        }

        public static IEnumerable<int> powers_finder(int num)
        {
            List<int> arr = new List<int>();
            int i = 1;
            while (i <= num)
            {
                if ((i & num) != 0)
                    arr.Add(i);
                i <<= 1;
            }
            return arr;
        }
        public static int PrimeCount(int m, int n)
        {
            int count = 0;
            for (int i = m; i < n; i++)
            {
                if (Enumerable.Range(1, i).Where(x => i % x == 0)
                                 .SequenceEqual(new[] { 1, i }))
                {
                    count++;
                }
            }

            return count;
        }


        public static int CommonDigit(int[] arr)
        {

            int[] result = new int[10];

            int maxIndex = 0;
            int maxCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int n = arr[i];
                while (n != 0)
                {
                    int y = n % 10;
                    n /= 10;
                    result[y] = result[y] + 1;
                    if (result[y] >= maxCount)
                    {
                        maxCount = result[y];
                        maxIndex = y;
                    }
                }
            }

            return maxIndex;
        }
        public static int DigitSum(int[] arr)
        {
            int maxIndex = 0;
            int maxCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int n = arr[i];
                int x = 0;
                while (n != 0)
                {
                    int y = n % 10;
                    n /= 10;
                    x += y;

                    if (x >= maxCount)
                    {
                        maxCount = x;
                        maxIndex = i;
                    }
                }
            }
            return maxIndex;
        }


        // Funtion in JS
        function fixage(years)
        {
            var arr = "";
            for (i = 0; i <= years.length; i++)
            {
                if (years[i] >= 18 && years[i] <= 60)
                {
                    arr += (years[i] + ',');
                }
            }

            if (arr.length == 0)
            {
                return '"NA"';
            }

            return arr.slice(0, arr.length - 1);
        }


        function Optional_Power(num1, num2)
        {
            var count = 0;

            if (confirm('are you sure!'))
            {
                for (i = 0; i <= num2; i++)
                {
                    count += num1;
                }

            }
            else
            {
                count = 0;
                for (i = 0; i <= num1; i++)
                {
                    count += num2;
                }

            }
            return count;
        }
    }
}
