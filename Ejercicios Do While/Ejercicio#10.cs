namespace Ejercicios_Do_While.Ejercicio10
{
    class Program
    {
        static void Main()
        {
            List<string> listaNombres = new List<string>();
            string nombre;

            do
            {
                Console.Write("Ingresa un nombre (escribe 'fin' para finalizar): ");
                nombre = Console.ReadLine();

                if (nombre.ToLower() != "fin")
                {
                    listaNombres.Add(nombre);
                }
            } while (nombre.ToLower() != "fin");

            Console.WriteLine("Nombres ingresados:");

            foreach (string item in listaNombres)
            {
                Console.WriteLine(item);
            }
        }
    }
}
