using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la cantidad en grados centígrados (Celsius):");
        if (double.TryParse(Console.ReadLine(), out double c))
        {
            Console.WriteLine("Seleccione a qué desea convertir:");
            Console.WriteLine("a. Fahrenheit");
            Console.WriteLine("b. Celsius");
            Console.WriteLine("c. Kelvin");

            string opcion = Console.ReadLine().ToLower();
            double resultado = 0;
            string unidad = "";

            switch (opcion)
            {
                case "a":
                    resultado = (c * 9.0 / 5.0) + 32;
                    unidad = "Fahrenheit";
                    break;
                case "b":
                    resultado = c;
                    unidad = "Celsius";
                    break;
                case "c":
                    resultado = c + 273.15;
                    unidad = "Kelvin";
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    return;
            }

            Console.WriteLine($"{c} grados centígrados equivalen a {resultado} {unidad}.");
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un valor numérico válido.");
        }
    }
}