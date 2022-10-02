using System.Collections.Generic;

namespace ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Prueba tecnica jimena alvarez\n");

            Console.WriteLine("\nPrimer ejercicio");
            string mensaje = "ejemplo primera funcionalidad añadida";
            ejercicioUno uno = new ejercicioUno(mensaje[0..20]);

            Console.WriteLine("\nSegundo ejercicio");            
            ejercicioDos dos = new ejercicioDos(30);

            Console.WriteLine("\nTercer ejercicio");
            int[] arreglo2 = { 2, 5, 7, 4, 23, 45, 66, 90, 10, 76, 32, 11, 8, 30, 20, 78, 53 };
            ejercicioTres tres = new ejercicioTres(arreglo2);

            Console.WriteLine("\nCuarto ejercicio");
            List<Car> Carros = new List<Car>() //Coleccion de Car
            {
                new Car("Ford",2016,"Black"),
                new Car("Mazda",2012,"Red"),
                new Car("Tsubaru",2006,"White"),
                new Car("Toyota",2017,"Black"),
                new Car("Ford",2015,"Grey"),
                new Car("Chevrolet",2009,"White"),
                new Car("Chevrolet",2018,"Red"),
                new Car("Ford",2020,"Grey"),
                new Car("Renault",2022,"Grey"),
                new Car("Chevrolet",2019,"White"),
                new Car("Mazda",2005,"Oranje"),
                new Car("Renault",2013,"Grey")
            };            
            imprime(Carros);
            Console.WriteLine("\nfin de la aplicacion");
        }

        public static void imprime(List<Car> Carros)
        {

            var modelosOrdenados2 = from Car in Carros
                                    where Car.Model >= 2018
                                    orderby Car.Model
                                    select Car;
            Console.WriteLine("Carros cuyo modelo es máximo de hace 5 años: \n");
            foreach (var modelo in modelosOrdenados2)
            {
                Console.WriteLine(modelo.Branch + " modelo: " + modelo.Model);
            }

        }


    }
}