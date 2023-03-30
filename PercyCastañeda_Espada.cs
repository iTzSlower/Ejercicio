using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea
{
    public class Espada : Renato_Melee
    {
        float damage;
        float price;
        string name;
        float speed;
        int handly;

        public Espada(string n, int p, int d, float s, int h)
        {
            name = n;
            price = p;
            damage = d;
            speed = s;
            handly = h;
        }
        public override float DPS()
        {
            return damage / speed;
        }
        public override void Mostrar()
        {
            Console.Clear();
            Console.WriteLine("-- Descripción --");
            Console.WriteLine($"Nombre     : {name}");
            Console.WriteLine($"Precio     : {price}");
            Console.WriteLine($"Daño       : {damage}");
            Console.WriteLine($"Velocidad  : {speed}");
            Console.WriteLine($"Manos      : {handly}");
            Console.WriteLine($"DPS        : {DPS()}");
        }
        public override string OnlyName()
        {
            return "Espada";
        }
        public override float OnlyBuy()
        {
            return price;
        }
    }
}
