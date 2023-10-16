using System;

namespace Ejercicios_Do_While.Ejercicio3
{
    class Program
    {
        static void Main()
        {
            int numero;
            int suma = 0;

            do
            {
                Console.Write("Ingresa un número (ingresa 0 para terminar): ");
                numero = int.Parse(Console.ReadLine());
                suma += numero;
            } while (numero != 0);

            Console.WriteLine("La suma de los números ingresados es: " + suma);
        }
    }
}

