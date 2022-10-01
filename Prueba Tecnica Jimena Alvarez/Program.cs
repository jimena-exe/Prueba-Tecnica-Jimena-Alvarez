namespace ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Prueba tecnica jimena alvarez");

            Console.WriteLine("Primer ejercicio");
            string mensaje = "ejemplo primera funcionalidad añadida";
            ejercicioUno uno = new ejercicioUno(mensaje[0..20]);

            Console.WriteLine("Segundo ejercicio");            
            ejercicioDos dos = new ejercicioDos(30);

            Console.WriteLine("Tercer ejercicio");
            int[] arreglo2 = { 2, 5, 7, 4, 23, 45, 66, 90, 10, 76, 32, 11, 8, 30, 20, 78, 53 };
            ejercicioTres tres = new ejercicioTres(arreglo2);            

            Console.WriteLine("fin de la aplicacion");
        }

    }
}