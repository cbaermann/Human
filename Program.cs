using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        class Human
        {
            public string Name { get; set; }
            public int Strength {get; set; } =3;
            public int Intelligence {get; set; }=3;
            public int Dexterity {get; set; }=3;
            private int health {get; set; }=100;

            public int Health{
                get {return health;}
            }

            public Human(string name, int strength, int intelligence, int dexterity, int health)
            {
                Name = name;
                Strength = strength;
                Intelligence = intelligence;
                Dexterity = dexterity;
                this.health = health;
            }


            public int Attack(Human target)
            {
                target.health -= 5 * Strength;
                return target.health;

            }
        }
    }
}
