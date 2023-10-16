namespace Ejercicios_ForEach.Ejercicio10
{
    class Program
    {
        static void Main()
        {
            List<int> numeros = new List<int> { 2, 3, 5, 7, 11 };

            int resultado = 1; // Inicializamos a 1 para la multiplicación

            foreach (int numero in numeros)
            {
                resultado *= numero;
            }

            Console.WriteLine("El resultado de la multiplicación es: " + resultado);
        }
    }

}
