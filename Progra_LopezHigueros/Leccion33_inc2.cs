using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese una frase:");
        string frase = Console.ReadLine();

        string fraseInvertida = "";

        for (int i = frase.Length - 1; i >= 0; i--)
        {
          
            fraseInvertida += frase[i];
        }

        Console.WriteLine("\nLa frase invertida es:");
        Console.WriteLine(fraseInvertida);
    }
}