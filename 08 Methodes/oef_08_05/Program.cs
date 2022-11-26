using System;
using System.Collections.Generic;

namespace oef_08_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = ReadNumber();
            int number2 = ReadNumber();
            List <int> even = GetEvenNumberBetween(number1, number2);
            PrintResult(even);
            Console.ReadLine();
        }
        private static int ReadNumber()
        {
            int number;
            string input;
            do
            {
                Console.Write("Geef een getal: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out number));
            return number;
        }
        private static bool IsEven(int number)
        {
            bool isEven;
            if (number%2 == 0)
            {
                isEven = true;
            }
            else
            {
                isEven=false;
            }
            return isEven;
        }
        private static List<int> GetEvenNumberBetween(int n1, int n2)
        {
            List<int> even = new List<int>();
            for (int i = n1; i >= n2; i--)
            {
                if (IsEven(i))
                {
                    even.Add(i);
                }
            }
            return even;
        }
        private static void PrintResult(List<int> numbers)
        {
            string output = String.Empty;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == numbers.Count-1)
                {
                    output += numbers[i];
                }
                else
                {
                    output += $"{numbers[i]} * ";
                }
            }
            Console.WriteLine(output);
        }
    }
}
