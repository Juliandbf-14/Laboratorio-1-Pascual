using System;

namespace Ejercicios_While.Ejercicio4
{
    class Program
{
    static void Main()
    {
        Console.Write("Ingresa una cadena: ");
        string cadena = Console.ReadLine().ToLower(); // Convertimos la cadena a minúsculas para simplificar la comparación

        int i = 0;
        int contadorVocales = 0;

        while (i < cadena.Length)
        {
            char caracter = cadena[i];
            if (EsVocal(caracter))
            {
                contadorVocales++;
            }

            i++;
        }

        Console.WriteLine("Cantidad de vocales: " + contadorVocales);
    }

    static bool EsVocal(char c)
    {
        // Verificamos si el carácter es una vocal (minúscula)
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }
}    
}

