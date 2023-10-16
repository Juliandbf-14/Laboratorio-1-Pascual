using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicios_While.Ejercicio3
{
    public class Program
    {
        public void Ejercicio2()
        {
            // 3. Implementa un juego de adivinanza en el que el usuario tiene que adivinar un número secreto.
            int numero = 0;
            int numeroSecreto = 7;
            int contador = 0;

            Console.Write("Adivina un número del 1 al 10: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if(numero == numeroSecreto){
                Console.WriteLine($"Has acertado el número");
            } else {
                while ((numero != numeroSecreto) && (contador <= 1))
                {
                    Console.WriteLine("Número incorrecto.");
			
					Console.Write("Adivina un número del 1 al 10: ");
					numero=Convert.ToInt32(Console.ReadLine());
					
					if (numero == numeroSecreto)
						Console.WriteLine("Numero Correcto.");
					
					contador = contador + 1;
                }
            }
        }
    }
}