namespace Ejercicios_ForEach.Ejercicio4
{
    
}

class Program
{
    static void Main()
    {
        Console.Write("Ingresa una cadena: ");
        string cadena = Console.ReadLine();

        Console.Write("Ingresa la letra que deseas contar: ");
        char letra = Console.ReadLine()[0]; // Tomamos solo el primer carácter para contar

        int contador = 0;

        foreach (char caracter in cadena)
        {
            if (caracter == letra)
            {
                contador++;
            }
        }

        Console.WriteLine("La letra '" + letra + "' aparece " + contador + " veces en la cadena.");
    }
}
