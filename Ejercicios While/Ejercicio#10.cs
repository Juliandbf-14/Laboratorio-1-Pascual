namespace Ejercicios_While.Ejercicio10
{
    class Program
    {
        static void Main()
        {
            string palabraSecreta = "elefante";
            string palabraAdivinada = new string('_', palabraSecreta.Length);
            int intentosRestantes = 6;

            Console.WriteLine("Bienvenido al juego de adivinanza de letras.");
            Console.WriteLine("La palabra secreta tiene " + palabraSecreta.Length + " letras.");
            Console.WriteLine("Tienes " + intentosRestantes + " intentos para adivinarla.");

            while (intentosRestantes > 0)
            {
                Console.WriteLine("\nPalabra actual: " + palabraAdivinada);
                Console.Write("Ingresa una letra: ");
                char letra = Char.ToLower(Console.ReadKey().KeyChar);

                if (!Char.IsLetter(letra))
                {
                    Console.WriteLine("\nIngresa una letra válida.");
                    continue;
                }

                if (palabraSecreta.Contains(letra))
                {
                    for (int i = 0; i < palabraSecreta.Length; i++)
                    {
                        if (palabraSecreta[i] == letra)
                        {
                            palabraAdivinada = palabraAdivinada.Remove(i, 1).Insert(i, letra.ToString());
                        }
                    }

                    if (palabraAdivinada == palabraSecreta)
                    {
                        Console.WriteLine("\n¡Felicidades! Has adivinado la palabra secreta: " + palabraSecreta);
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("\nLa letra no está en la palabra secreta.");
                    intentosRestantes--;
                    Console.WriteLine("Intentos restantes: " + intentosRestantes);
                }
            }

            if (intentosRestantes == 0 && palabraAdivinada != palabraSecreta)
            {
                Console.WriteLine("\n¡Agotaste tus intentos! La palabra secreta era: " + palabraSecreta);
            }
        }
    }

}

