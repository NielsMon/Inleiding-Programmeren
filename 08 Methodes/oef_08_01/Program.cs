using System;

namespace oef_08_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = ReadNumber();
            int number2 = ReadNumber();
            int number3 = ReadNumber();
            string letter = ReadLetter();
            int code = ReadNumberCode();

            if (letter.ToLower() == "a")
            {
                if (code == 1)
                {
                    PrintResult(number1, number2, letter, Sum(number1, number2));
                }
                else if (code == 2)
                {
                    PrintResult(number2, number3, letter, Sum(number2, number3));
                }
                else if (code == 3)
                {
                    PrintResult(number1, number3, letter, Sum(number1, number3));
                }
            }else if (letter.ToLower() == "b")
            {
                if (code == 1)
                {
                    PrintResult(number1, number2, letter, Substract(number1, number2));
                }
                else if (code == 2)
                {
                    PrintResult(number2, number3, letter, Substract(number2, number3));
                }
                else if (code == 3)
                {
                    PrintResult(number1, number3, letter, Substract(number1, number3));
                }
            }
            CloseProgram();
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
        private static string ReadLetter()
        {
            string input;
            do
            {
                Console.Write("Geef een letter (A/B): ");
                input= Console.ReadLine();
            } while (input.ToLower() != "a" && input.ToLower() != "b");
            return input;
        }
        private static int ReadNumberCode()
        {
            int code;
            do
            {
                code = ReadNumber();
            } while (code != 1 && code != 2 && code != 3);
            return code;
        }
        private static int Sum(int x, int y)
        {
            return x + y;
        }
        private static int Substract(int x, int y)
        {
            return x - y;
        }
        private static void PrintResult(int n1, int n2, string operation, int result)
        {
            
            string op = operation.ToLower() == "a"? "+" : "-";
            Console.WriteLine($"{n1} {op} {n2} = {result}");
        }
        private static void CloseProgram()
        {
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
            Console.ReadLine();
        }
    }
}
