
namespace Ejercicios_While.Ejercicio5
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingresa un número entero no negativo: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("El número debe ser no negativo.");
            }
            else
            {
                long factorial = CalcularFactorial(numero);
                Console.WriteLine($"El factorial de {numero} es {factorial}");
            }
        }

        static long CalcularFactorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1; // El factorial de 0 y 1 es 1
            }

            long factorial = 1;
            int i = 2;

            while (i <= n)
            {
                factorial *= i;
                i++;
            }

            return factorial;
        }
    }
}

