
namespace Ejercicios_While.Ejercicio7
{
    class Program
    {
        static void Main()
        {
            List<int> numeros = new List<int>();

            // Llenar la lista con números
            Console.WriteLine("Ingresa una serie de números (ingresa '0' para terminar):");
            while (true)
            {
                string entrada = Console.ReadLine();
                if (entrada == "0")
                    break;

                if (int.TryParse(entrada, out int numero))
                {
                    numeros.Add(numero);
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Ingresa un número válido.");
                }
            }

            if (numeros.Count > 0)
            {
                int numeroMasGrande = EncontrarNumeroMasGrande(numeros);
                Console.WriteLine("El número más grande en la lista es: " + numeroMasGrande);
            }
            else
            {
                Console.WriteLine("La lista está vacía.");
            }
        }

        static int EncontrarNumeroMasGrande(List<int> lista)
        {
            int maximo = lista[0];
            int i = 1;

            while (i < lista.Count)
            {
                if (lista[i] > maximo)
                {
                    maximo = lista[i];
                }

                i++;
            }

            return maximo;
        }
    }
}
