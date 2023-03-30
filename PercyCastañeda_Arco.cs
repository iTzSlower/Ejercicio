using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea
{
    class Arco : Renato_Range
    {
        float damage;
        float price;
        string name;
        float speed;
        Projectile flecha;

        public Arco(string n, int p, int d, int s, Projectile f)
        {
            name = n;
            price = p;
            damage = d;
            speed = s;
            flecha = f;
        }

        public override float DPS()
        {
            return damage / speed;
        }
        public override float TotalDamage()
        {
            return flecha.OnlyDamage() + damage;
        }
        public override void Mostrar()
        {
            Console.Clear();
            Console.WriteLine("-- Descripción --");
            Console.WriteLine($"Nombre     : {name}");
            Console.WriteLine($"Precio     : {price}");
            Console.WriteLine($"Daño       : {damage}");
            Console.WriteLine($"Velocidad  : {speed}");
            Console.WriteLine($"Municion   : {flecha.OnlyName()}");
            Console.WriteLine($"Daño Total : {TotalDamage()}");
            Console.WriteLine($"DPS        : {DPS()}");
        }
        public override string OnlyName()
        {
            return "Arco";
        }
        public override float OnlyBuy()
        {
            return price;
        }
    }
}
