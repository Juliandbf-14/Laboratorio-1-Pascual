namespace Ejercicios_For.Ejercicio2
{
    using System;

    class Program
    {
        static void Main()
        {
            int suma = 0;
            int contador = 0;

            for (int numero = 2; contador < 10; numero += 2)
            {
                suma += numero;
                contador++;
            }

            Console.WriteLine("La suma de los primeros 10 números pares es: " + suma);
        }
    }

}