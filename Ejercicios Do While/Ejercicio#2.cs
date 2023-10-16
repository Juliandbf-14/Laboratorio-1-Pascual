using System;

namespace Ejercicios_Do_While.Ejercicio2
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int numeroGenerado;

            do
            {
                numeroGenerado = random.Next(1, 101); // Genera un número aleatorio entre 1 y 100
                Console.WriteLine("Número generado: " + numeroGenerado);
            } while (numeroGenerado <= 90);

            Console.WriteLine("Se ha generado un número mayor que 90. El programa ha terminado.");
        }
    }
}
