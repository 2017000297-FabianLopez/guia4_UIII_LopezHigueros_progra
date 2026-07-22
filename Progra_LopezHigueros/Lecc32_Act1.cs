using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la cantidad en metros:");

    
        double metros = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Seleccione a qué desea convertir:");
        Console.WriteLine("a. Milímetros");
        Console.WriteLine("b. Centímetros");
        Console.WriteLine("c. Decímetros");
        Console.WriteLine("d. Hectómetros");
        Console.WriteLine("e. Kilómetros");

        string opcion = Console.ReadLine().ToLower();

        double resultado = 0;
        string unidad = "";

      
        switch (opcion)
        {
            case "a":
                resultado = metros * 1000;
                unidad = "milímetros";
                break;
            case "b":
                resultado = metros * 100;
                unidad = "centímetros";
                break;
            case "c":
                resultado = metros * 10;
                unidad = "decímetros";
                break;
            case "d":
                resultado = metros / 100;
                unidad = "hectómetros";
                break;
            case "e":
                resultado = metros / 1000;
                unidad = "kilómetros";
                break;
            default:
                Console.WriteLine("Opción no válida.");
                return; 
        }

        
        Console.WriteLine($"{metros} metros equivale a {resultado} {unidad}.");
    }
}