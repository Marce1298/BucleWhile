using System;

namespace BucleWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("¿Deseas entran en el bucle while?");

            string respuesta = Console.ReadLine();

            while (respuesta != "no")
            {
                Console.WriteLine("Estas ejecuanto el interior del bucle while");

                Console.WriteLine("Introduce tu nombre porfavor");

                string nombre = Console.ReadLine();

                Console.WriteLine($"Saldrás del bucle {nombre} cuando respondas 'no'a la pregunta");

                Console.WriteLine("¿Deseas repetir otra vez?");

                respuesta = Console.ReadLine();
            }
            Console.WriteLine("Has salido del bucle");


        }
    }
}
