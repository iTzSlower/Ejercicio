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

        public Espada(string n, int p, int d,float s, int h)
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
    class Arco : Renato_Range
    {
        float damage;
        float price;
        string name;
        float speed;
        Projectile flecha;

        public Arco(string n, int p, int d, int s,Projectile f)
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
