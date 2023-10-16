namespace Ejercicios_Do_While.Ejercicio7
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingresa un número: ");
            int numero = int.Parse(Console.ReadLine());

            int contadorDigitos = 0;
            int numeroTemporal = Math.Abs(numero); // Tomamos el valor absoluto para manejar números negativos

            if (numero == 0)
            {
                contadorDigitos = 1;
            }
            else
            {
                do
                {
                    contadorDigitos++;
                    numeroTemporal /= 10;
                } while (numeroTemporal > 0);
            }

            Console.WriteLine("El número ingresado tiene " + contadorDigitos + " dígitos.");
        }
    }
}
