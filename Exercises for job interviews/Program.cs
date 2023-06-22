// Write two different functions (pseudo code) that accept a number and calculate the assembly of it A number.
// int CalculateFactorialRecursive(int n)
// {
//     if (n == 0 || n == 1)
//     {
//         return 1;
//     }
//     else
//     {
//         return n * CalculateFactorialRecursive(n - 1);
//     }

//     int result = 1;
//     for (int i = 2; i <= n; i++)
//     {
//         result *= i;
//     }
//     return result;
// }

// int y = CalculateFactorialRecursive(5);
// System.Console.WriteLine(y);


using System.Linq;
using System;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        public static bool IsPalindrome(string str)
        {
            if (str.Length <= 1)
                return true;

            if (str[0] != str[str.Length - 1])
                return false;

            return IsPalindrome(str.Substring(1, str.Length - 2).ToLower());
        }

        public static bool isPalindrome(string str)

        {
            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right])
                    return false;

                left++;
                right--;
            }

            return true;
        }

        // public static void GenerateFibonacciSequence(int limit)
        // {
        //     int current = 0;
        //     int next = 1;

        //     while (current <= limit)
        //     {
        //         System.Console.WriteLine(current);

        //         int temp = current + next;
        //         current = next;
        //         next = temp;
        //     }
        // }







        static int BinarySearchRecursive(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int mid = (right - left) / 2;

                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (arr[mid] > target)
                {
                    right = mid - 1;
                }
                else left = mid + 1;
            }

            return -1;
        }

        static string RemoveVowels(string input)
        {
            string vowels = "aeiouAEIOU";
            string result = "";

            foreach (char c in input)
            {
                if (!vowels.Contains(c))
                {
                    result += c;
                }
            }

            return result;
        }

        static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }


        static bool IsPrimeNumber(int number, int divisor = 2)
        {
            if (number < 2)
            {
                return false;
            }

            if (divisor > Math.Sqrt(number)) return true;

            if (number % divisor == 0) return false;

            return IsPrimeNumber(number, divisor + 1);
        }

        static int FindNextPrime(int number)
        {
            int nextNumber = number + 1;
            while (!IsPrime(nextNumber))
            {
                nextNumber++;
            }
            return nextNumber;
        }

        static int CalculateFactorialRecursive(int number)
        {

            if (number == 0 || number == 1) return 1;

            return number * CalculateFactorialRecursive(number - 1);
        }

        // public static int Fibonacci(int n)
        // {
        //     if (n <= 1)
        //         return n;

        //     return Fibonacci(n - 1) + Fibonacci(n - 2);
        // }

        public static void GenerateFibonacciSequence(int limit)
        {
            int current = 0;
            int next = 1;

            while (current <= limit)
            {
                System.Console.WriteLine(current);

                int temp = current + next;
                current = next;
                next = temp;
            }
        }

        public static void PrintFibonacciSequence(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                int fib = Fibonacci(i);
                System.Console.WriteLine(fib);
            }
        }

        public static int Fibonacci(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1 || n == 2)
                return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static int Bainary(int[] arr, int target, int left, int right)
        {
            while (left <= right)
            {
                int mid = (right - left) / 2;

                if (arr[mid] == target) return mid;
                else if (arr[mid] > target) return Bainary(arr, target, left, mid - 1);
                else return Bainary(arr, target, mid + 1, right);
            }
            return -1;
        }

        static int[] BubbleSort(int[] arr)
        {

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int swap = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = swap;
                    }
                }
            }
            return arr;
        }




        static void Main(string[] args)
        {


            int[] arr = { 1, 9, 5, 3, 2, 4, 6, 7, 8, 9, 3, 444, 555, 6 };
            var x = BubbleSort(arr);

            foreach (var item in x)
            {
                System.Console.Write(item + " ");
            }
            // int[] arr = { 1, 2, 3, 4, 5, 5 };



            // string[] y = x.Split(" ");
            // string longest = "";
            // int maxLength = 0;

            // for (int i = 0; i < y.Length; i++)
            // {
            //     if (y[i].Length > maxLength)
            //     {
            //         maxLength = y[i].Length;
            //         longest = y[i];
            //     }
            // }

            // Console.WriteLine($"The length of the longest word is: {maxLength}");
            // System.Console.WriteLine(longest);

            // int max = int.MinValue;
            // int secondMax = int.MinValue;

            // int[] arr = { 1, 11112, 3, 99, 3, 1, 2222, 2223 };

            // for (int i = 0; i < arr.Length; i++)
            // {

            //     if(arr[i] > max){
            //         secondMax = max;
            //         max = arr[i];
            //     }

            //     else if(arr[i] > secondMax){
            //         secondMax = arr[i];
            //     }
            // }

            // System.Console.WriteLine(max);
            // System.Console.WriteLine(secondMax);



            // int[] arr = { 1, 2, -5, 3, 4, 5, 6, 1, 2 };

            // string str = "dsfkaso 230 samdm 2423 sa";


            // string[] values = str.Split(' ');

            // List<int> integers = new List<int>();

            // foreach (string value in values)
            // {
            //     int num;
            //     if (int.TryParse(value, out num))
            //     {
            //         integers.Add(num);
            //     }
            // }

            // Console.WriteLine("Array with only integer values:");
            // foreach (int integer in integers)
            // {
            //     Console.Write(integer + " ");
            // }



            // string str = "JavaScript";

            // string result = RemoveVowels(str);

            // Console.WriteLine("Original string: " + str);
            // Console.WriteLine("After removing all the vowels from the said string: " + result);



            // string str = "2^sdfds*^*^jlljdslfnoswje34u230sdfds984";

            // List<char> nonLetters = new List<char> { '!', '@', '#', '$', '%', '^', '&', '*', ')', '(' };

            // StringBuilder x = new StringBuilder();

            // foreach (var item in str)
            // {

            //     if(!nonLetters.Contains(item)){
            //         x.Append(item);
            //     }
            // }

            // System.Console.WriteLine(x);

            // StringBuilder result = new StringBuilder();

            // foreach (char c in str)
            // {
            //     if (Char.IsLetter(c))
            //     {
            //         result.Append(c);
            //     }
            // }

            // string cleanedString = result.ToString();

            // Console.WriteLine("Original string: " + str);
            // Console.WriteLine("Remove all characters from the said string which are non-letters: " + cleanedString);


            // string str = "javascript";

            // var x = str.ToCharArray();
            // Array.Sort(x);
            // string sortedString = string.Join("", x);
            // System.Console.WriteLine(sortedString.GetType());
            // System.Console.WriteLine(sortedString);

            // int[] arr = { 1, 2, 8 };

            // int first = arr[0];
            // int last = arr[arr.Length - 1];

            // for (int i = arr.Length - 1; i > 0; i--)
            // {
            //     arr[i] = arr[i - 1];
            // }

            // arr[0] = last;

            // foreach (var item in arr)
            // {
            //     System.Console.WriteLine(item);
            // }
            // int first = arr[0];

            // for (int i = 0; i < arr.Length - 1; i++)
            // {
            //     arr[i] = arr[i + 1];
            // }

            // arr[arr.Length - 1] = first;

            // foreach (var item in arr)
            // {
            //     System.Console.WriteLine(item);
            // }
            // foreach (var item in y)
            // {
            //     System.Console.Write(item + " ");
            // }
            // string input = "hello world";
            // Dictionary<char, int> result = CountCharacters(input);

            // foreach (var kvp in result)
            // {
            //     Console.WriteLine($"Character: {kvp.Key}, Count: {kvp.Value}");
            // }

            // int sum = 0;
            // int Count = 0;
            // int number = 2;

            // while (500 > Count)
            // {

            //     if (IsPrimeNumber(number))
            //     {
            //         sum+= number;
            //         Count++;
            //     }
            //     number++;
            // }
            // System.Console.WriteLine(sum);

            // int x = 521;
            // int sum = 0;
            // while (x > 0)
            // {
            //     int z = x % 10;
            //     sum += z;
            //     x /= 10;
            // }
            // System.Console.WriteLine(sum);

            // string sentence = "Display the pattern like pyramid using the alphabet.";

            // string[] words = sentence.Split(' ');

            // Array.Reverse(words);

            // string reversedSentence = string.Join(" ", words);

            // Console.WriteLine("Original String: " + sentence);
            // Console.WriteLine("Reverse String: " + reversedSentence);


            // string filePath = @"C:/Users/97250/Desktop/output.txt";

            // FileInfo fileInfo = new FileInfo(filePath);

            // long fileSizeInBytes = fileInfo.Length;

            // Console.WriteLine("Size of a file: " + fileSizeInBytes);

            // string str = "Hello World";

            // var x = str.Replace(" ", "");

            // Dictionary<char, int> xxx = new Dictionary<char, int>();

            // foreach (var item in x)
            // {
            //     if (xxx.ContainsKey(item))
            //     {
            //         xxx[item]++;
            //     }
            //     else xxx[item] = 1;
            // }

            // foreach (var item in xxx)
            // {
            //     System.Console.WriteLine($"{item.Key}  {item.Value}");
            // }

            // string xy = "";

            // foreach (var item in x)
            // {
            //     if (!xy.Contains(item))
            //     {
            //         xy += item;
            //     }
            // }

            // System.Console.WriteLine(xy);

            //  2 + 3 + 4 = 9

            // int[] arr1 = { 1, 2, 3, 4, 5, 5 };

            // int max1 = int.MinValue;
            // int max2 = int.MinValue;
            // int max3 = int.MinValue;

            // for (int i = 0; i < arr1.Length; i++)
            // {
            //     if (arr1[i] > max1)
            //     {
            //         max3 = max2;
            //         max2 = max1;
            //         max1 = arr1[i];
            //     }
            //     else if (arr1[i] >= max2 && arr1[i] != max1)
            //     {
            //         max3 = max2;
            //         max2 = arr1[i];
            //     }
            //     else if (arr1[i] >= max3 && arr1[i] != max1 && arr1[i] != max2)
            //     {
            //         max3 = arr1[i];
            //     }
            // }
            // System.Console.WriteLine(max1);
            // System.Console.WriteLine(max2);
            // System.Console.WriteLine(max3);

            // array1: [3, 7, 9, 2, 5]
            // array2: [2, 5, 1, 9, 4]

            // Common elements: [2, 5, 9]

            // int[] array1 = { 3, 7, 9, 2, 5 };
            // int[] array2 = { 2, 5, 1, 9, 4 };
            // List<int> array3 = new List<int>();

            // for (int i = 0; i < array1.Length; i++)
            // {
            //     for (int j = 0; j < array2.Length; j++)
            //     {
            //         if (array1[i] == array2[j])
            //         {
            //             array3.Add(array1[i]);
            //             break;
            //         }
            //     }
            // }

            // foreach (var item in array3.ToArray())
            // {
            //     System.Console.WriteLine(item);
            // }


        }

    }
}