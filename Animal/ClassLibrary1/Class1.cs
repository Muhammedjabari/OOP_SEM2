using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Life { get; set; }

        public int Hunger { get; set; }

        public string Feed { get; set; }

        public abstract void move();
        

        public string BloodType { get; set; }

        public Animal(string name, int life, int hunger, string feed, string move, string bloodtype)
        {
            this.Name = name;
            this.Life = life;
            this.Hunger = hunger;
            this.Feed = feed;
            this.BloodType = bloodtype;

        }

    }

    //public abstract class BodyParts :
    //{
    //    public int Eyes { get; set; }
    //    public int Limbs { get; set; }

    //}

    public abstract class Reptile : Animal
    {

        public string scale { get; set; }
        public Reptile(string scale, string Name, int Life,int Hunger,string Feed,string Move, string BloodType): 
            base(Name, Life, Hunger, Feed, Move, BloodType)
        {
            this.scale = scale;
        }

    }

    public abstract class Mamal : Animal
    {
        public string Hair { get; set; }
        public string TempRegulation { get; set; }
        public Mamal(string Hair,string TempeRegulation, string Name, int Life, int Hunger, string Feed, string Move, string BloodType)
            : base(Name, Life, Hunger, Feed, Move, BloodType)
        {
            this.Hair =Hair;
        }

    }

    public abstract class Dog : Mamal
    {
        public int Legs { get; set;}

        public Dog(int Legs,string Hair,string TempRegulation, string Name, int Life, int Hunger, string Feed, string Move, string BloodType) 
            : base(Hair,TempRegulation,Name, Life, Hunger, Feed, Move, BloodType)
        {
            this.Legs = Legs;
        }
        public override void move()
        {
            Console.WriteLine("run");
        }

    }

    public abstract class Cat : Mamal
    {
        public int Legs { get; set; }

        public Cat(int Legs, string Hair, string TempRegulation, string Name, int Life, int Hunger, string Feed, string Move, string BloodType)
            : base(Hair, TempRegulation, Name, Life, Hunger, Feed, Move, BloodType)
        {
            this.Legs = Legs;
        }
        public override void move()
        {
            Console.WriteLine("jump");
        }

    }
    public abstract class Snake : Reptile
    {
        public string Venom { get; set; }
        public Snake(string Venom,string Scale,string Name, int Life, int Hunger, string Feed, string Move, string BloodType)
            : base(Scale,Name, Life, Hunger, Feed, Move, BloodType)
        {
            this.Venom = Venom;
        
        }
        public override void move()
        {
            Console.WriteLine("slither");
        }
    }

}
