using System;
namespace ejercicios
{
    public class ejercicioUno
    {
        public ejercicioUno(string mensaje)
        {
            for (int i = 0; i < mensaje.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(mensaje + "...");
                }

            }

        }
    }
}

