using System;
using System.IO;

namespace Alis
{
    class Program
    {
        public static int apple = 0, equatorial = 0, lemon = 0, malta = 0, grapes = 0, pineapple = 0, classic = 0, peach = 0;
        public enum Taste { peach, equatorial, lemon, malta, grapes, pineapple, classic, apple};
        static void Menu()
        {
            Console.WriteLine("Please choose --admin-- or --user-- . Enter it.");
            string AdminOrUser = Console.ReadLine();
            if (AdminOrUser == "admin")
                    admin();
            if (AdminOrUser == "user")
                    user();
            else if(AdminOrUser!="admin" && AdminOrUser!="user")
            {
                Console.WriteLine("Incorect input.Please enter --admin-- or --user-- ");
                Menu();
            }
        }
        static int plusPlus(ref int taste)
        {
            return taste++;
        }
        static void user()
        {
            bool boolean = true;
            while (boolean)
            {
                Console.WriteLine("Enter your favorite taste or --change-- .");
                string searchWord = Console.ReadLine();
                try
                {
                    if (searchWord != "change")
                    {
                        Taste taste = (Taste)Enum.Parse(typeof(Taste), searchWord.ToLower());
                        if (taste == Taste.apple)
                        {
                            Console.WriteLine("Exist");
                            plusPlus(ref apple);
                        }
                        if (taste == Taste.classic)
                        {
                            Console.WriteLine("Exist");
                            plusPlus(ref classic);
                        }
                        if (taste == Taste.equatorial)
                        {
                            Console.WriteLine("Exist");
                            plusPlus(ref equatorial);
                        }
                        if (taste == Taste.grapes)
                        {
                            Console.WriteLine("Exist");
                            plusPlus(ref grapes);
                        }
                        if (taste == Taste.lemon)
                        {
                            Console.WriteLine("Exist");
                            plusPlus(ref lemon);
                        }
                        if (taste == Taste.malta)
                        {
                            Console.WriteLine("Exist");
                            plusPlus(ref malta);
                        }
                        if (taste == Taste.peach)
                        {
                            Console.WriteLine("Exist");
                            plusPlus(ref peach);
                        }
                        if (taste == Taste.pineapple)
                        {
                            Console.WriteLine("Exist");
                            plusPlus(ref pineapple);
                        }
                        boolean = true;
                    }
                }
                catch 
                {
                        Console.WriteLine("Don't exist");
                }
                if(searchWord=="change")
                    boolean = false;
            }
            Menu();
        }
        static void admin()
        {
            Console.WriteLine("Please enter the password");
            string password = Console.ReadLine();
            if (password == "1234ABcd")
            {
                bool boolean = true;
                while (boolean)
                {
                    Console.WriteLine("Please enter --exite-- or --count-- or --change--");
                    string searchWord = Console.ReadLine();
                    if (searchWord.ToLower() == "count")
                    {
                        Console.WriteLine("Which taste do you want to be searched?");
                        string str_searchTaste = Console.ReadLine();
                        Taste searchTaste = (Taste)Enum.Parse(typeof(Taste), str_searchTaste.ToLower());
                        if (searchTaste == Taste.apple)
                            Console.WriteLine($"{searchTaste} {apple} time has been searched . ");
                        if (searchTaste == Taste.classic)
                            Console.WriteLine($"{searchTaste} {classic} time has been searched . ");
                        if (searchTaste == Taste.equatorial)
                            Console.WriteLine($"{searchTaste} {equatorial} time has been searched . ");
                        if (searchTaste == Taste.grapes)
                            Console.WriteLine($"{searchTaste} {grapes} time has been searched . ");
                        if (searchTaste == Taste.lemon)
                            Console.WriteLine($"{searchTaste} {lemon} time has been searched . ");
                        if (searchTaste == Taste.malta)
                            Console.WriteLine($"{searchTaste} {malta} time has been searched . ");
                        if (searchTaste == Taste.peach)
                            Console.WriteLine($"{searchTaste} {peach} time has been searched . ");
                        if (searchTaste == Taste.pineapple)
                            Console.WriteLine($"{searchTaste} {pineapple} time has been searched . ");
                        boolean = true;
                    }
                    if (searchWord.ToLower() == "exite")
                    {
                        Console.WriteLine("program has been finished");
                        boolean = false;
                    }
                    if (searchWord.ToLower() == "change")
                    {
                        Menu();
                    }
                }
            }
            else
            {
                Console.WriteLine("incorect password.Try again");
                admin();
            }
        }
        static void Main(string[] args)
        {
            Menu();
        }
    }
}
