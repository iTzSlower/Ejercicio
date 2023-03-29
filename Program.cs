using System;

namespace Tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            Inicio();
        }

        static void Inicio()
        {
            Console.WriteLine("Bienvenido a la tienda");
            Console.WriteLine(" ");
            Console.WriteLine("1.- ¿Que es lo que vende?");
            Console.WriteLine("2.- No deseo nada (salir)");
            Respuesta();
        }
        static void Respuesta()
        {
            string a = Console.ReadLine();
            if (a == "1")
            {

            }
            else if (a == "2")
            {

            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("---Caracter invalido---");
                Console.WriteLine(" ");
                Inicio();
            }
        }

    }
}
