using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Calculadora de Índice de Masa Corporal (IMC) ---");
        Console.Write("Ingrese su peso en kg: ");

        if (double.TryParse(Console.ReadLine(), out double peso) && peso > 0)
        {
            Console.Write("Ingrese su altura en metros (ej. 1.75): ");
            if (double.TryParse(Console.ReadLine(), out double altura) && altura > 0)
            {
                // Fórmula: IMC = peso / (altura * altura)
                double imc = peso / (altura * altura);
                Console.WriteLine($"\nSu Índice de Masa Corporal (IMC) es: {imc:F2}");
            }
            else
            {
                Console.WriteLine("\nAltura no válida.");
            }
        }
        else
        {
            Console.WriteLine("\nPeso no válida.");
        }
    }
}
