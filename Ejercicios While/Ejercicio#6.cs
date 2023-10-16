namespace Ejercicios_While.Ejercicio6
{
    class Program
    {
        static void Main()
        {
            int contador = 10;

            Console.WriteLine("Contador regresivo:");

            while (contador >= 1)
            {
                Console.WriteLine(contador);
                contador--;

                // Pausa de 1 segundo para simular el conteo regresivo.
                Thread.Sleep(1000);
            }
            Console.WriteLine("¡Tiempo agotado!");
        }
    }
}
