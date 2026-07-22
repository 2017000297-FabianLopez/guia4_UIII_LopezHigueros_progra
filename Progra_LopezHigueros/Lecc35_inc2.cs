using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Calculadora de Cambio ---");
        Console.Write("Ingrese el precio del producto: ");
        if (double.TryParse(Console.ReadLine(), out double precio))
        {
            Console.Write("Ingrese con cuánto pagó el cliente: ");
            if (double.TryParse(Console.ReadLine(), out double pago))
            {
                if (pago >= precio)
                {
                    double cambio = pago - precio;
                    Console.WriteLine($"\nCambio total a devolver: ${cambio}");

                    int b200 = (int)(cambio / 200);
                    cambio %= 200;

                    int b100 = (int)(cambio / 100);
                    cambio %= 100;

                    int b50 = (int)(cambio / 50);
                    cambio %= 50;

                    int b20 = (int)(cambio / 20);
                    cambio %= 20;

                    double monedas = cambio;

                    Console.WriteLine($"Billetes de 200: {b200}");
                    Console.WriteLine($"Billetes de 100: {b100}");
                    Console.WriteLine($"Billetes de 50: {b50}");
                    Console.WriteLine($"Billetes de 20: {b20}");
                    Console.WriteLine($"Monedas / Resto: {monedas}");
                }
                else
                {
                    Console.WriteLine("El pago es insuficiente para cubrir el precio del producto.");
                }
            }
        }
    }
}