using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea
{
    class Pistola : Renato_Range
    {
        float damage;
        float price;
        string name;
        float speed;
        Projectile balas;

        public Pistola(string n, int p, int d, int s, Projectile b)
        {
            name = n;
            price = p;
            damage = d;
            speed = s;
            balas = b;
        }

        public override float DPS()
        {
            return damage / speed;
        }
        public override float TotalDamage()
        {
            return balas.OnlyDamage() + damage;
        }
        public override void Mostrar()
        {
            Console.Clear();
            Console.WriteLine("-- Descripción --");
            Console.WriteLine($"Nombre     : {name}");
            Console.WriteLine($"Precio     : {price}");
            Console.WriteLine($"Daño       : {damage}");
            Console.WriteLine($"Velocidad  : {speed}");
            Console.WriteLine($"Municion   : {balas.OnlyName()}");
            Console.WriteLine($"Daño Total : {TotalDamage()}");
            Console.WriteLine($"DPS        : {DPS()}");
        }
        public override string OnlyName()
        {
            return "Pistola";
        }
        public override float OnlyBuy()
        {
            return price;
        }
    }
}
