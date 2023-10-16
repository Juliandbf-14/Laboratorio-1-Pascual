namespace Ejercicios_For.Ejercicio1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingresa una cadena: ");
            string cadena = Console.ReadLine().ToLower(); // Convertimos la cadena a minúsculas para simplificar la comparación

            int contadorVocales = 0;

            for (int i = 0; i < cadena.Length; i++)
            {
                char caracter = cadena[i];
                if (EsVocal(caracter))
                {
                    contadorVocales++;
                }
            }

            Console.WriteLine("Cantidad de vocales en la cadena: " + contadorVocales);
        }

        static bool EsVocal(char c)
        {
            // Verificamos si el carácter es una vocal (minúscula)
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        }
    }
}