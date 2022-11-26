using System;

namespace oef_01_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variabelen declareren
            double gradenCelsius, gradenFahrenheit;

            // waarden opvragen
            Console.Write("Geef het aantal °C: ");

            // waarden inlezen
            gradenCelsius = double.Parse(Console.ReadLine());

            // berekeningen maken
            gradenFahrenheit = gradenCelsius * 9 / 5 + 32;

            // resultaat afdrukken
            Console.WriteLine($"Fahrenheit: {gradenFahrenheit}");
        }
    }
}
