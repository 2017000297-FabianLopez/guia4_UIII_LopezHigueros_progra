using System;

class Program
{
    static void Main()
    {
       
        string[] nombres = new string[10];
        string[] telefonos = new string[10];

        Console.WriteLine("--- Registro de Agenda ---");
        Console.WriteLine("Por favor, ingrese los datos de 10 personas.\n");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Ingrese el nombre de la persona {i + 1}: ");
            nombres[i] = Console.ReadLine();

            Console.Write($"Ingrese el teléfono de {nombres[i]}: ");
            telefonos[i] = Console.ReadLine();

            Console.WriteLine("----------------------------");
        }

        Console.WriteLine("\n--- Búsqueda en la Agenda ---");
        Console.Write("Ingrese el número de posición de la lista (1 al 10) que desea buscar: ");

      
        if (int.TryParse(Console.ReadLine(), out int posicion))
        {
            
            int indice = posicion - 1;

            if (indice >= 0 && indice < 10)
            {
                Console.WriteLine("\n--- Datos Encontrados ---");
                Console.WriteLine($"Posición: {posicion}");
                Console.WriteLine($"Nombre: {nombres[indice]}");
                Console.WriteLine($"Teléfono: {telefonos[indice]}");
            }
            else
            {
                Console.WriteLine("\nError: La posición ingresada no existe. Debe ser un número del 1 al 10.");
            }
        }
        else
        {
            Console.WriteLine("\nError: Por favor ingrese un valor numérico válido.");
        }
    }
}