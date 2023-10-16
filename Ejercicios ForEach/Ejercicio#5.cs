namespace Ejercicios_ForEach.Ejercicio5
{
    class Program
    {
        static void Main()
        {
            List<double> calificaciones = new List<double> { 95.5, 88.0, 76.5, 89.5, 92.0 };

            double suma = 0.0;
            int contador = 0;

            foreach (double calificacion in calificaciones)
            {
                suma += calificacion;
                contador++;
            }

            if (contador > 0)
            {
                double promedio = suma / contador;
                Console.WriteLine("El promedio de las calificaciones es: " + promedio);
            }
            else
            {
                Console.WriteLine("La lista de calificaciones está vacía.");
            }
        }
    }
}
