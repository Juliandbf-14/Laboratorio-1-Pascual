namespace Ejercicios_ForEach.Ejercicio2
{
    class Program
    {
        static void Main()
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int suma = 0;

            foreach (int numero in numeros)
            {
                suma += numero;
            }

            Console.WriteLine("La suma de los números en la lista es: " + suma);
        }
    }
}