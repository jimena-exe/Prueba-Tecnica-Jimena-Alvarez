using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios
{
    public class ejercicioDos
    {
        public ejercicioDos(int numero)
        {
            int x = 0;
            int y = 1;
            Console.WriteLine("1");
            for (int i = 0; i < numero; i++)
            {
                int z = x + y;
                Console.WriteLine(z + " ");
                x = y;
                y = z;
            }
            Console.WriteLine("sí cumple!");
            Console.ReadKey();

        }
    }
}
