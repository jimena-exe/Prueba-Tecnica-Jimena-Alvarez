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

            Console.WriteLine("fin de la aplicacion");
        }

    }
}