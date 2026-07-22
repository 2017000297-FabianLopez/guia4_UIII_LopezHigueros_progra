using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la medida del primer lado del triángulo:");
        double lado1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la medida del segundo lado:");
        double lado2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la medida del tercer lado:");
        double lado3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n--- Resultado ---");

        
        if (lado1 == lado2 && lado2 == lado3)
        {
            Console.WriteLine("El triángulo es EQUILÁTERO (todos sus lados son iguales).");
        }
        
        else if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
        {
            Console.WriteLine("El triángulo es ESCALENO (todos sus lados son diferentes).");
        }
       
        else
        {
            Console.WriteLine("El triángulo es ISÓSCELES (tiene dos lados iguales).");
        }
    }
}