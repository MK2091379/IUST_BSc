using System;

namespace HW8
{
    interface IPersonality
    {
        string name { get; set; }
        int rate { get; set; }
        string Personality();
    }
    class Bear : IPersonality
    {
        string Name;
        int Rate;
        public Bear(string name , int rate)
        {
            this.Name = name;
            this.Rate = rate;
        }
        public string name { get => Name; set => Name = value; }
        public int rate { get => Rate; set => Rate = value; }

        public string Personality()
        {
            return $"Pooh is yellow bear.\nHe loves honey.\nHis name's rate is {rate}";
        }
    }
    class Pig : IPersonality
    {
        string Name;
        int Rate;
        public Pig(string name, int rate)
        {
            this.Name = name;
            this.Rate = rate;
        }
        public string name { get => Name; set => Name = value; }
        public int rate { get => Rate; set => Rate = value; }

        public string Personality()
        {
            return $"Piglet is pink pig.\nHe is cowardly.\nHis name's rate is {rate}";
        }
    }
    class Tiger : IPersonality
    {
        string Name;
        int Rate;
        public Tiger(string name, int rate)
        {
            this.Name = name;
            this.Rate = rate;
        }
        public string name { get => Name; set => Name = value; }
        public int rate { get => Rate; set => Rate = value; }

        public string Personality()
        {
            return $"Tiger is tiger.\nHe is smiling.\nHis name's rate is {rate}";
        }
    }
    class kangaroo : IPersonality
    {
        string Name;
        int Rate;
        public kangaroo(string name, int rate)
        {
            this.Name = name;
            this.Rate = rate;
        }
        public string name { get => Name; set => Name = value; }
        public int rate { get => Rate; set => Rate = value; }

        public string Personality()
        {
            return $"Roo is platful baby kangaroo.\nHe is Tiger's friend.\nHis name's rate is {rate}";
        }
    }
    class Donkey : IPersonality
    {
        string Name;
        int Rate;
        public Donkey(string name, int rate)
        {
            this.Name = name;
            this.Rate = rate;
        }
        public string name { get => Name; set => Name = value; }
        public int rate { get => Rate; set => Rate = value; }

        public string Personality()
        {
            return $"Eeyore is tired donkey.\nHe is grumble.\nHis name's rate is {rate}";
        }
    }
    class Friend<T> where T : IPersonality
    {
        public T field;
        public Friend(T field)
        {
            this.field = field;
        }
        public string method()
        {
            string output = "";
            if(typeof(T).Equals(typeof(Bear)))
            {
                Bear Pooh = new Bear("Pooh", 5);
                output = Pooh.Personality();
            }
            if (typeof(T).Equals(typeof(Tiger)))
            {
                Tiger Tiger = new Tiger("Tiger", 3);
                output = Tiger.Personality();
            }
            if (typeof(T).Equals(typeof(Pig)))
            {
                Pig Piglet = new Pig("Piglet", 4);
                output = Piglet.Personality();
            }
            if (typeof(T).Equals(typeof(Donkey)))
            {
                Donkey Eeyore = new Donkey("Eeyore", 1);
                output = Eeyore.Personality();
            }
            if (typeof(T).Equals(typeof(kangaroo)))
            {
                kangaroo Roo = new kangaroo("Roo", 5);
                output = Roo.Personality();
            }
            return output;
        }
        public static implicit operator Friend<T>(T from)
        {
            return new Friend<T>(from);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Friend<Bear> bear = new Bear("Pooh", 5);
            Console.WriteLine(bear.method());
            Console.WriteLine("----------------------");
            Friend<Tiger> tiger = new Tiger("Tiger", 3);
            Console.WriteLine(tiger.field.Personality());
            Console.WriteLine("----------------------");
            Friend<Pig> pig = new Pig("Piglet", 4);
            Console.WriteLine(pig.field.Personality());
            Console.WriteLine("----------------------");
            Friend<kangaroo> kangaroo = new kangaroo("Roo", 2);
            Console.WriteLine(kangaroo.field.Personality());
            Console.WriteLine("----------------------");
            Friend<Donkey> donkey = new Donkey("Eeyore", 5);
            Console.WriteLine(donkey.field.Personality());
            Console.WriteLine("----------------------");
        }
    }
}
