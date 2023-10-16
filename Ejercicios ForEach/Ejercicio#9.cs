namespace Ejercicios_ForEach.Ejercicio9
{
    class Program
    {
        static void Main()
        {
            List<int> numeros = new List<int> { 5, 2, 8, 1, 3, 4, 7, 6 };

            int maximo = int.MinValue; // Inicializamos maximo con el valor mínimo posible
            int minimo = int.MaxValue; // Inicializamos minimo con el valor máximo posible

            foreach (int numero in numeros)
            {
                if (numero > maximo)
                {
                    maximo = numero;
                }

                if (numero < minimo)
                {
                    minimo = numero;
                }
            }

            Console.WriteLine("El número máximo en la lista es: " + maximo);
            Console.WriteLine("El número mínimo en la lista es: " + minimo);
        }
    }
}
