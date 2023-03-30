using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea
{
    class Projectile : Renato_Weapon
    {
        float damage;
        float price;
        string name;
        public Projectile(string n, int p, int d)
        {
            name = n;
            price = p;
            damage = d;
        }
        public override void Mostrar()
        {
            Console.Clear();
            Console.WriteLine("-- Descripción --");
            Console.WriteLine($"Nombre     : {name}");
            Console.WriteLine($"Precio     : {price}");
            Console.WriteLine($"Daño       : {damage}");
        }
        public override string OnlyName()
        {
            return name;
        }
        public float OnlyDamage()
        {
            return damage;
        }
        public override float OnlyBuy()
        {
            return price;
        }
    }
}
