
namespace Ejercicios_ForEach.Ejercicio1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingresa una cadena: ");
            string cadena = Console.ReadLine();

            foreach (char caracter in cadena)
            {
                Console.WriteLine(caracter);
            }
        }
    }
}

