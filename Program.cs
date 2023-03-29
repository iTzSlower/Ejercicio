using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Program
    {
        static float Dinero = 435;
        static List<Renato_Weapon> TiendaInventario = new List<Renato_Weapon>();
        static List<Renato_Weapon> PersonajeInventario = new List<Renato_Weapon>();


        static void Main(string[] args)
        {
            Agregar();
            Inicio();
        }
        static void Agregar()
        {
            Projectile a = new Projectile("Balas", 25, 10);
            Projectile b = new Projectile("Flechas", 25, 5);

            //name , precio , damage
            TiendaInventario.Add(new Espada("Espada Media", 100, 10, 1, 1));
            TiendaInventario.Add(new Arco("Arco corto", 100, 10, 1, a));
            TiendaInventario.Add(new Pistola("Glock 18", 100, 10, 1, b));
            TiendaInventario.Add(a);
            TiendaInventario.Add(b);
        }

        static void Respuesta()
        {
            string a = Console.ReadLine();
            if (a == "1")
            {
                Tienda();
            }
            else if (a == "2")
            {
                RevisarInventario();
            }
            else if (a == "3")
            {
                Console.Clear();
                Console.WriteLine("Adios.");
                Environment.Exit(0);
            }
            else
            {
                Inicio();
                Console.WriteLine(" ");
                Console.WriteLine("---Caracter invalido---");
                Console.WriteLine(" ");
            }
        }
        static void Inicio()
        {
            Console.Clear();
            Console.WriteLine("Bienvenido a la tienda");
            Console.WriteLine(" ");
            Console.WriteLine("1.- ¿Que es lo que vende?");
            Console.WriteLine("2.- Revisar Inventario");
            Console.WriteLine("3.- No deseo nada (salir)");
            Console.WriteLine(" ");
            Console.WriteLine($"Dinero:    {Dinero}");
            Console.WriteLine(" ");
            Respuesta();
        }
        static void Tienda()
        {
            int contador = 1;
            Console.Clear();
            Console.WriteLine("-- Tenemos --");
            Console.WriteLine(" ");
            foreach (Renato_Weapon t in TiendaInventario)
            {
                Console.WriteLine($"{contador}.- {t.OnlyName()}");
                contador += 1;
            }
            Console.WriteLine(" ");
            Console.WriteLine($"{contador}.- Regresar");
            Console.WriteLine(" ");
            string a = Console.ReadLine();

            if(Int32.Parse(a) == contador)
            {
                Inicio();
            }
            else if(Int32.Parse(a) -1 < contador && Int32.Parse(a) - 1 > -1)
            {
                Comprar(Int32.Parse(a) - 1);
            }
            else
            {
                Tienda();
                Console.WriteLine(" ");
                Console.WriteLine("---Caracter invalido---");
                Console.WriteLine(" ");
            }
        }

        static void Comprar(int d)
        {
            int index = d;
            Console.Clear();
            TiendaInventario[index].Mostrar();
            Console.WriteLine("");
            Console.WriteLine("1.- Comprar");
            Console.WriteLine("2.- volver a mirar"); 
            Console.WriteLine("");
            Console.WriteLine($"Dinero:    {Dinero}");
            string a = Console.ReadLine();
            if(a == "1")
            {
                if (TiendaInventario[index].OnlyBuy() <= Dinero)
                {
                    PersonajeInventario.Add(TiendaInventario[index]);
                    Dinero -= TiendaInventario[index].OnlyBuy();
                    Tienda();
                }
                else
                {
                    Comprar(index);
                    Console.WriteLine("-- FALTA DINERO -- ");
                }
            }
            else if (a == "2")
            {
                Tienda();
            }
            else
            {
                Comprar(d);
            }
        }
        static void RevisarInventario()
        {
            Console.Clear();
            int contador = 1;
            Console.WriteLine("-- Inventario --");
            Console.WriteLine(" ");
            foreach (Renato_Weapon t in PersonajeInventario)
            {
                Console.WriteLine($"{contador}.- {t.OnlyName()}");
                contador += 1;
            }
            Console.WriteLine(" ");
            Console.WriteLine($"{contador}.- Regresar");
            Console.WriteLine(" ");
            string a = Console.ReadLine();

             if (Int32.Parse(a) == contador)
            {
                Inicio();
            }
            else
            {
                RevisarInventario();
            }

        }
    }
    
}
