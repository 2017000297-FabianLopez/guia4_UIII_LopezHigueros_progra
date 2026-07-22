using System;

class Program
{
    static void Main()
    {
        string jugarDeNuevo = "s";
        Random random = new Random();

        while (jugarDeNuevo.ToLower() == "s")
        {
            Console.Clear();
            Console.WriteLine("--- Piedra, Papel o Tijera ---");
            Console.WriteLine("Elija una opción:");
            Console.WriteLine("1. Piedra");
            Console.WriteLine("2. Papel");
            Console.WriteLine("3. Tijeras");
            Console.Write("Su opción (1-3): ");

            if (int.TryParse(Console.ReadLine(), out int opcionUsuario) && opcionUsuario >= 1 && opcionUsuario <= 3)
            {
                int opcionCpu = random.Next(1, 4); 

                string[] opciones = { "", "Piedra", "Papel", "Tijeras" };
                Console.WriteLine($"\nUsted eligió: {opciones[opcionUsuario]}");
                Console.WriteLine($"La computadora eligió: {opciones[opcionCpu]}");

                if (opcionUsuario == opcionCpu)
                {
                    Console.WriteLine("\n¡Empate!");
                }
                else if ((opcionUsuario == 1 && opcionCpu == 3) ||
                         (opcionUsuario == 2 && opcionCpu == 1) ||
                         (opcionUsuario == 3 && opcionCpu == 2))
                {
                    Console.WriteLine("\n¡Felicidades, usted ganó!");
                }
                else
                {
                    Console.WriteLine("\n¡Gana la computadora!");
                }
            }
            else
            {
                Console.WriteLine("\nOpción no válida.");
            }

            Console.Write("\n¿Desea jugar de nuevo? (s/n): ");
            jugarDeNuevo = Console.ReadLine();
        }
    }
}