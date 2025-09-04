using System;
using System.Globalization;

namespace setup
{
    public class calculator
    {
        public static void Main()
        {
            Console.WriteLine("Zadejte výpočet (např. 4 + 5):");
            string input = Console.ReadLine();

            // Rozdělení vstupu podle mezer a odstranění prázdných částí
            string[] parts = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length != 3)
            {
                Console.WriteLine("Chybný formát! Použijte: číslo operátor číslo");
                return;
            }

            try
            {
                // Převod na čísla s tečkou (např. 4.5)
                double a = double.Parse(parts[0], CultureInfo.InvariantCulture);
                string op = parts[1];
                double b = double.Parse(parts[2], CultureInfo.InvariantCulture);

                double result = 0;

                switch (op)
                {
                    case "+":
                        result = a + b;
                        break;
                    case "-":
                        result = a - b;
                        break;
                    case "*":
                        result = a * b;
                        break;
                    case "/":
                        if (b == 0)
                        {
                            Console.WriteLine("Chyba: Dělení nulou!");
                            return;
                        }
                        result = a / b;
                        break;
                    case "**":
                        result = Math.Pow(a, b);
                        break;
                    default:
                        Console.WriteLine("Neplatný operátor!");
                        return;
                }

                Console.WriteLine($"{a} {op} {b} = {result}");
            }
            catch
            {
                Console.WriteLine("Chyba při zpracování vstupu. Používejte tečku pro desetinná čísla.");
            }
        }
    }
}
