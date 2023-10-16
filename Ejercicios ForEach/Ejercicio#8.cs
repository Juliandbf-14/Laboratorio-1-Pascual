namespace Ejercicios_ForEach.Ejercicio8
{
    class Program
    {
        static void Main()
        {
            List<int> numeros = new List<int> { 5, 2, 8, 1, 3, 4, 7, 6 };

            numeros.Sort();

            Console.WriteLine("Números ordenados en orden ascendente:");

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
