using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese su mes de nacimiento (1-12):");
        int mes = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese su día de nacimiento:");
        int dia = Convert.ToInt32(Console.ReadLine());

        string signo = "";
        string mensaje = "";

       
        if ((mes == 3 && dia >= 21) || (mes == 4 && dia <= 19))
        {
            signo = "Aries"; mensaje = "Tu energía te ayudará a cumplir tus metas hoy.";
        }
        else if ((mes == 4 && dia >= 20) || (mes == 5 && dia <= 20))
        {
            signo = "Tauro"; mensaje = "La paciencia traerá grandes recompensas.";
        }
        else if ((mes == 5 && dia >= 21) || (mes == 6 && dia <= 20))
        {
            signo = "Géminis"; mensaje = "Estarás muy comunicativo, aprovecha para hablar.";
        }
        else if ((mes == 6 && dia >= 21) || (mes == 7 && dia <= 22))
        {
            signo = "Cáncer"; mensaje = "Día ideal para estar en familia.";
        }
        else if ((mes == 7 && dia >= 23) || (mes == 8 && dia <= 22))
        {
            signo = "Leo"; mensaje = "Brillarás con luz propia a donde vayas.";
        }
        else if ((mes == 8 && dia >= 23) || (mes == 9 && dia <= 22))
        {
            signo = "Virgo"; mensaje = "El orden te dará mucha paz mental.";
        }
        else if ((mes == 9 && dia >= 23) || (mes == 10 && dia <= 22))
        {
            signo = "Libra"; mensaje = "Encontrarás el equilibrio en tu vida.";
        }
        else if ((mes == 10 && dia >= 23) || (mes == 11 && dia <= 21))
        {
            signo = "Escorpio"; mensaje = "Tu pasión te llevará a un nuevo descubrimiento.";
        }
        else if ((mes == 11 && dia >= 22) || (mes == 12 && dia <= 21))
        {
            signo = "Sagitario"; mensaje = "Una aventura inesperada tocará a tu puerta.";
        }
        else if ((mes == 12 && dia >= 22) || (mes == 1 && dia <= 19))
        {
            signo = "Capricornio"; mensaje = "Un gran cambio se aproxima en tu vida.";
        }
        else if ((mes == 1 && dia >= 20) || (mes == 2 && dia <= 18))
        {
            signo = "Acuario"; mensaje = "Tu creatividad estará al máximo hoy.";
        }
        else if ((mes == 2 && dia >= 19) || (mes == 3 && dia <= 20))
        {
            signo = "Piscis"; mensaje = "Sigue tu intuición, te guiará bien.";
        }
        else
        {
            Console.WriteLine("Fecha de nacimiento no válida.");
            return;
        }

        Console.WriteLine($"\nTu signo zodiacal es: {signo}");
        Console.WriteLine($"Horóscopo: {mensaje}");
    }
}