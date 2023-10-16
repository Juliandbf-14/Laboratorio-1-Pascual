using System;

namespace Ejercicios_Do_While.Ejercicio5
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);
            int intentos = 0;
            int intentoUsuario;

            Console.WriteLine("¡Bienvenido al juego de adivinanza del número secreto!");
            Console.WriteLine("Estoy pensando en un número entre 1 y 100. ¡Adivina cuál es!");

            do
            {
                Console.Write("Ingresa tu intento: ");
                if (int.TryParse(Console.ReadLine(), out intentoUsuario))
                {
                    intentos++;

                    if (intentoUsuario < numeroSecreto)
                    {
                        Console.WriteLine("El número secreto es mayor. Intenta de nuevo.");
                    }
                    else if (intentoUsuario > numeroSecreto)
                    {
                        Console.WriteLine("El número secreto es menor. Intenta de nuevo.");
                    }
                    else
                    {
                        Console.WriteLine($"¡Felicidades! Adivinaste el número secreto ({numeroSecreto}) en {intentos} intentos.");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingresa un número válido.");
                }
            } while (intentoUsuario != numeroSecreto);

            Console.WriteLine("Gracias por jugar.");
        }
    }

}

