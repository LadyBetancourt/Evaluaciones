using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Ingresa la calificación: ");
        int calificacion = int.Parse(Console.ReadLine());

        
        if (calificacion >= 70)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"La calificación es de {calificacion}, aprobado");
        }
        else if (calificacion > 50)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"La calificación es de {calificacion}, reprobado con derecho a regularizar");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"La calificación es de {calificacion}, reprobado debe volver a cursar");
        }

        
        Console.ResetColor();
    }
}

