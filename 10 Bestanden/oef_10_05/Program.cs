using System;
using System.IO;

namespace oef_10_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = Console.ReadLine();
            Console.WriteLine(LeesFile(file));
        }
        private static string LeesFile(string bestandsnaam)
        {
            int counter = 0;
            int points = 0;
            string output = "";

            if (File.Exists(bestandsnaam))
            {
                
                using (StreamReader streamReader = new StreamReader(bestandsnaam))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string record = streamReader.ReadLine();
                        string[] data = record.Split(";");
                        int numberOne = int.Parse(data[1]);
                        int numberTwo = int.Parse(data[2]);
                        string bewerking = data[0];
                        Console.Write($"{numberOne} {bewerking} {numberTwo} = ");
                        
                        int result = 0;
                        switch (bewerking)
                        {
                            case "+": result = numberOne + numberTwo; break;
                            case "-": result = numberOne - numberTwo; break;
                            case "*": result = numberOne * numberTwo; break;
                            case "/": result = numberOne / numberTwo; break;
                        }
                        counter++;
                        if (Console.ReadLine() == result.ToString())
                        {
                            points++;
                        }
                    }
                }
                output = $"Je scoorde {points} op {counter}";
            }
            else
            {
                output = $"{bestandsnaam} bestaat niet";
            }
            return output;
        }
    }
}
