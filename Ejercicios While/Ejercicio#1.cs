namespace Ejercicios_While.Ejercicio1
{
    class Program
    {
        public void Ejercicio1()
        {
            // 1. Escribe un programa que imprima números del 1 al 10. Con While
            int numero = 1;

            while (numero <= 10)
            {
                Console.WriteLine($"El número es: {numero}");
                numero++;
            }
        }
    }
}