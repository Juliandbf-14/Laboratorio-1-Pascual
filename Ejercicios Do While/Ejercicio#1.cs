namespace Ejercicios_Do_While.Ejercicio1
{
    class Program
    {
        static void Main()
        {
            int numero;
            do
            {
                Console.Write("Ingresa un número (ingresa un número negativo para salir): ");
                numero = int.Parse(Console.ReadLine());

                if (numero >= 0)
                {
                    Console.WriteLine("Número ingresado: " + numero);
                }
            } while (numero >= 0);

            Console.WriteLine("Has ingresado un número negativo. El programa ha terminado.");
        }
    }
}

