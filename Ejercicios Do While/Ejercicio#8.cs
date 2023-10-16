namespace Ejercicios_Do_While.Ejercicio8
{
    class Program
    {
        static void Main()
        {
            string[] opciones = { "piedra", "papel", "tijeras" };
            Random random = new Random();
            string decisionUsuario;
            string decisionComputadora;

            do
            {
                Console.WriteLine("Juguemos a piedra, papel, tijeras. Elige una opción:");
                Console.WriteLine("1. Piedra");
                Console.WriteLine("2. Papel");
                Console.WriteLine("3. Tijeras");
                Console.WriteLine("4. Salir");
                Console.Write("Ingresa tu elección (1-4): ");
                int eleccion = int.Parse(Console.ReadLine());

                if (eleccion == 4)
                {
                    break; // Salir del juego
                }
                else if (eleccion >= 1 && eleccion <= 3)
                {
                    decisionUsuario = opciones[eleccion - 1];

                    int indiceComputadora = random.Next(0, 3);
                    decisionComputadora = opciones[indiceComputadora];

                    Console.WriteLine("Elegiste " + decisionUsuario);
                    Console.WriteLine("La computadora eligió " + decisionComputadora);

                    if (decisionUsuario == decisionComputadora)
                    {
                        Console.WriteLine("Es un empate.");
                    }
                    else if ((decisionUsuario == "piedra" && decisionComputadora == "tijeras") ||
                             (decisionUsuario == "papel" && decisionComputadora == "piedra") ||
                             (decisionUsuario == "tijeras" && decisionComputadora == "papel"))
                    {
                        Console.WriteLine("¡Ganaste!");
                    }
                    else
                    {
                        Console.WriteLine("La computadora gana.");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingresa una opción válida (1-4).");
                }
            } while (true);

            Console.WriteLine("Gracias por jugar. ¡Hasta luego!");
        }
    }
}
