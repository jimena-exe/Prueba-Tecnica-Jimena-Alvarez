using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios
{
    public class ejercicioTres
    {
        public ejercicioTres(int[] arreglo2)
        {
            int contador_par = 0;
            int contador_impar = 0;

            for (int i = 0; i < arreglo2.Length; i++)
            {
                if ((arreglo2[i] % 2) == 0)
                {
                    contador_par++;
                    //Console.WriteLine(arreglo2[i] + " es par");
                }
                else
                {
                    contador_impar++;
                    //Console.WriteLine(arreglo2[i] + " es impar");
                }
            }

            Array.Sort(arreglo2);
            Array.Reverse(arreglo2);
            foreach (int value in arreglo2)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine("\ncantidad de pares: " + contador_par);
            Console.WriteLine("cantidad de impares: " + contador_impar);


        }
    }
}
