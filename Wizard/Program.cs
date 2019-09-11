using System;

namespace Wizard
{
    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        public int health;

        public int Health
        {
            get
            {
                return health;
            }
        }

        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        public Human(string name, int str, int intel, int dex, int hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;
        }
        public virtual int Attack(Human target)
        {
            int dmg = Strength * 3;
            target.health -= dmg;
            System.Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.health;
        }
    }
    class Wizard : Human
    {
        public Wizard(string name, int hp = 50, int intel = 25) : base(name)
        {

        }
        public override int Attack(Human target)
        {
            int dmg = Intelligence * 5;
            target.health -= dmg;
            this.health += dmg;
            System.Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.health;
        }
        public int Heal(Human target)
        {
            int dmg = Intelligence * 10;
            target.health += dmg;
            System.Console.WriteLine($"{Name} healed {target.Name} for {dmg} hp!");
            return target.health;
        }

    }

    class Ninja : Human
    {
        public Ninja(string name, int dex = 175) : base(name)
        {
            
        }
          public override int Attack(Human target)
        {
            int dmg = Dexterity * 5;
            target.health -= dmg;
            Random rand = new Random();
            int hit = rand.Next(1,6);
            if(hit == 1){
                System.Console.WriteLine("Critical hit! 10 additional points of damage.");
                target.health -= 10;
            }
            System.Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.health;
        }
        public int Steal(Human target)
        {
            target.health -= 5;
            this.health += 5;
            System.Console.WriteLine($"{Name} stole 5 hp from {target.Name}!");
            return target.health;
        }
    }
    class Samurai : Human
    {
        public Samurai(string name, int hp = 200) : base(name)
        {
            
        }
            public override int Attack(Human target)
        {
            int dmg = Strength * 3;
            target.health -= dmg;
            if(target.health < 50){
                target.health = 0;
            }
            else{
                System.Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            }
            return target.health;
        }
        public int Meditate()
        {
            this.health = 200;
            System.Console.WriteLine($"{Name} meditates and heals back to full health.");
            return this.health;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
