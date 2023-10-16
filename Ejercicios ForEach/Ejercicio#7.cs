namespace Ejercicios_ForEach.Ejercicio7
{
    class Program
    {
        static void Main()
        {
            List<string> nombres = new List<string>
        {
            "Juan",
            "Ana",
            "Pedro",
            "María",
            "Carlos"
        };

            Console.WriteLine("Nombres en la lista:");

            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }
        }
    }
}
