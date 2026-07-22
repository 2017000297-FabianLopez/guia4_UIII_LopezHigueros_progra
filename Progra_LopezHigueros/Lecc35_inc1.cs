using System;

class Program
{
    static void Main()
    {
        string continuar = "s";

        
        while (continuar.ToLower() == "s")
        {
            Console.Clear();
            Console.WriteLine("--- Convertidor de Moneda ---");
            Console.Write("Ingrese la cantidad en su moneda local: ");

            if (double.TryParse(Console.ReadLine(), out double cantidad))
            {
                Console.WriteLine("\nEquivalente en 5 países:");

                
                Console.WriteLine($"1. Estados Unidos (Dólar): ${cantidad * 0.13:F2}");
                Console.WriteLine($"2. Europa (Euro): €{cantidad * 0.12:F2}");
                Console.WriteLine($"3. México (Peso mexicano): ${cantidad * 2.20:F2}");
                Console.WriteLine($"4. Japón (Yen): ¥{cantidad * 20.50:F2}");
                Console.WriteLine($"5. Reino Unido (Libra): £{cantidad * 0.10:F2}");
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un valor numérico válido.");
            }

            Console.Write("\n¿Desea convertir otra cantidad? (s/n): ");
            continuar = Console.ReadLine();
        }
    }
}