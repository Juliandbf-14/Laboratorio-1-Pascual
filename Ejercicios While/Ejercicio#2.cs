namespace Ejercicios_While.Ejercicio2
{
    class Program
    {
        public void Ejercicio2()
        {
            // 2. Crea un programa que sume todos los números pares del 1 al 100.
            int numero = 1;

            while (numero <= 100) {

                if(numero %2 == 0){
                    Console.WriteLine(numero);
                }
                
                numero++;
            }
        }
    }
}