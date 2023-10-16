
namespace Ejercicios_Do_While.Ejercicio6
{
    class Program
    {
        static void Main()
        {
            int numero = 1;
            int suma = 0;

            do
            {
                if (numero % 2 == 0)
                {
                    suma += numero;
                }

                numero++;
            } while (numero <= 100);

            Console.WriteLine("La suma de los números pares entre 1 y 100 es: " + suma);
        }
    }
}
