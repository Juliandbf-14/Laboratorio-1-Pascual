using System;
namespace Ejercicios_While.Ejercicio9
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingresa un número para generar la tabla de multiplicar: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Tabla de multiplicar del " + numero + ":");

            int multiplicador = 1;

            while (multiplicador <= 10)
            {
                int resultado = numero * multiplicador;
                Console.WriteLine(numero + " x " + multiplicador + " = " + resultado);
                multiplicador++;
            }
        }
    }
}
