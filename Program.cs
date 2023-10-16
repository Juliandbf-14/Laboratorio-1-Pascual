namespace Laboratorio
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Desarrolla un programa que cuente la cantidad de vocales en una cadena.
            int[] vocales = {0, 0, 0, 0, 0};
            int contador = 0;

            Console.WriteLine("Ingresa una palabra");
            string? cadena = Console.ReadLine();

            while (contador != cadena.Length)
            {   
                switch (cadena.ToLower().Substring(contador, contador + 1))
                {   
                    case "a": 
                        vocales[0]++;
                    break;
                    case "e": 
                        vocales[1]++;
                    break;
                    case "i": 
                        vocales[2]++;
                    break;
                    case "o": 
                        vocales[3]++;
                    break;
                    case "u": 
                        vocales[4]++;
                    break;
                    default:
                    break;
                }
                contador++;
            }
            Console.WriteLine($"La cadena tiene: \n"
                + $"{vocales[0]} de A\n"
                + $"{vocales[1]} de E\n"
                + $"{vocales[2]} de I\n"
                + $"{vocales[3]} de 0\n"
                + $"{vocales[4]} de U\n"
            );

        }
    }
}