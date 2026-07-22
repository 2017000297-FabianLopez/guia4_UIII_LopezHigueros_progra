using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Conversor Numérico ---");
        Console.WriteLine("1. Convertir de Decimal a Binario");
        Console.WriteLine("2. Convertir de Binario a Decimal");
        Console.Write("Elija una opción (1 o 2): ");

        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                Console.Write("Ingrese un número decimal positivo: ");
                
                if (int.TryParse(Console.ReadLine(), out int numDecimal))
                {
                    string binario = "";
                    int aux = numDecimal;

                    if (aux == 0)
                    {
                        binario = "0";
                    }
                    else
                    {
                        
                        while (aux > 0)
                        {
                            int residuo = aux % 2;
                            binario = residuo.ToString() + binario;
                            aux = aux / 2;
                        }
                    }
                    Console.WriteLine($"\nEl número en binario es: {binario}");
                }
                else
                {
                    Console.WriteLine("\nPor favor, ingrese un número válido.");
                }
                break;

            case "2":
                Console.Write("Ingrese un número binario (solo 0 y 1): ");
                string numBinario = Console.ReadLine();
                int decimalCalculado = 0;
                int potencia = 0;

                
                for (int i = numBinario.Length - 1; i >= 0; i--)
                {
                    if (numBinario[i] == '1')
                    {
                   
                        decimalCalculado += (int)Math.Pow(2, potencia);
                    }
                    else if (numBinario[i] != '0')
                    {
                        Console.WriteLine("\nError: El texto ingresado contiene números diferentes de 0 y 1.");
                        return; 
                    }
                    potencia++;
                }
                Console.WriteLine($"\nEl número en decimal es: {decimalCalculado}");
                break;

            default:
                Console.WriteLine("\nOpción no válida.");
                break;
        }
    }
}