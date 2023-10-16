namespace Ejercicios_ForEach.Ejercicio6
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingresa una cadena: ");
            string cadena = Console.ReadLine();

            char[] caracteres = cadena.ToCharArray();
            char[] cadenaInvertida = new char[caracteres.Length];
            int indice = caracteres.Length - 1;

            foreach (char caracter in caracteres)
            {
                cadenaInvertida[indice] = caracter;
                indice--;
            }

            string cadenaResultado = new string(cadenaInvertida);
            Console.WriteLine("Cadena invertida: " + cadenaResultado);
        }
    }
}
