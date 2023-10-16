namespace Ejercicios_While.Ejercicio8
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingresa un número entero: ");
            int numero = int.Parse(Console.ReadLine());

            int suma = CalcularSumaDigitos(numero);
            Console.WriteLine("La suma de los dígitos de " + numero + " es " + suma);
        }

        static int CalcularSumaDigitos(int numero)
        {
            int suma = 0;

            // Tomamos el valor absoluto del número para manejar números negativos
            numero = Math.Abs(numero);

            while (numero > 0)
            {
                int digito = numero % 10; // Obtenemos el último dígito
                suma += digito; // Sumamos el dígito a la suma
                numero /= 10; // Eliminamos el último dígito
            }

            return suma;
        }
    }
}
