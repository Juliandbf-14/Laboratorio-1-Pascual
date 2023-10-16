using System;

namespace Ejercicios_Do_While.Ejercicio4
{
    class Program
    {
        static void Main()
        {
            string contraseñaCorrecta = "Colombia123";
            string contraseñaIngresada;

            do
            {
                Console.Write("Ingresa la contraseña: ");
                contraseñaIngresada = Console.ReadLine();

                if (contraseñaIngresada != contraseñaCorrecta)
                {
                    Console.WriteLine("Contraseña incorrecta. Intenta de nuevo.");
                }
            } while (contraseñaIngresada != contraseñaCorrecta);

            Console.WriteLine("¡Contraseña correcta! Bienvenido.");
        }
    }
}