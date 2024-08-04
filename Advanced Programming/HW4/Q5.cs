using System;
using System.Collections.Generic;
using System.IO;

namespace Zoo
{
    public class Care
    {
        private int ID;
        public enum Animals { elephant = 9644, lion = 9600, tiger = 9611, monkey = 9633, giraffe = 9655, owl = 9666, bear = 9622 };
        private Animals Name;
        public string Location;
        public string Food;
        public int Numbers;
        public int[] FoodTime = new int[3];
        public Care(int ID, Animals Name, string Location, string Food, int Numbers, int[] Foodtime)
        {
            this.Food = Food;
            this.ID = ID;
            this.Location = Location;
            this.Name = Name;
            this.FoodTime = Foodtime;
            this.Numbers = Numbers;
        }
        public Care()
        {

        }
        public void SetFoodTime(Care Ani)
        {
            string FileName = Ani.ID.ToString() + ".txt";
            Random generator = new Random();
            if (Ani.Food != "meet")
            {
                Ani.FoodTime[0] = generator.Next(6, 22);
                Ani.FoodTime[1] = Ani.FoodTime[1] + generator.Next(2, 4);
                Ani.FoodTime[2] = Ani.FoodTime[2] + generator.Next(2, 4);
                if (Ani.FoodTime[2] > 22 || Ani.FoodTime[1] > 22)
                    SetFoodTime(Ani);
            }
            if (Ani.Food == "meet")
            {
                if (extract(FileName) == 22)
                {
                    Ani.FoodTime[2] = generator.Next(17,21);
                }
            }
        }
        public void SaveToFile(Care Ani)
        {
            string FileName = Ani.ID.ToString() + ".txt";
            StreamWriter writer = new StreamWriter(FileName);
            writer.WriteLine($"ID : {Ani.ID}");
            writer.WriteLine($"Location : {Ani.Location}");
            writer.WriteLine($"Food : {Ani.Food}");
            writer.WriteLine($"FoodTime : {Ani.FoodTime[0]} - {Ani.FoodTime[1]} - {Ani.FoodTime[2]}");
            writer.WriteLine($"Number : {Ani.Numbers}");
            writer.Close();
        }
        public static void AllInfo(Care[] Animals)
        {
            StreamWriter writer = new StreamWriter("Zoo.txt");
            for (int i = 0; i < Animals.Length; i++)
            {
                writer.Write($"{Animals[i].Name} - {Animals[i].ID}");
                writer.Write("\n");
            }
            writer.Close();
        }
        static int extract(string filePath)
        {
            string spicificLine;
            StreamReader reader = new StreamReader(filePath);
            List<string> fileInformation = new List<string>();
            while (reader.EndOfStream == false)
            {
                string line = "";
                line = reader.ReadLine();
                fileInformation.Add(line);
            }
            reader.Close();
            spicificLine = fileInformation[3];
            int digit1 = (int)Char.GetNumericValue(spicificLine[spicificLine.Length - 1]);
            int digit2 = (int)Char.GetNumericValue(spicificLine[spicificLine.Length - 1]);
            return digit1 + digit2 * 10;
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the number of animals to save");
                int number = int.Parse(Console.ReadLine());
                Care[] Animals = new Care[number];
                for(int i = 0; i < number; i++)
                {
                    Console.WriteLine("enter the code");
                    int code = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter the location");
                    string location = Console.ReadLine();
                    Console.WriteLine("enter the food");
                    string food = Console.ReadLine();
                    Console.WriteLine("enter the foodtime");
                    int[] foodtime = new int[3];
                    foodtime[0] = int.Parse(Console.ReadLine());
                    foodtime[1] = int.Parse(Console.ReadLine());
                    foodtime[2] = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter the number");
                    int num = int.Parse(Console.ReadLine());
                    Care ANIMAL = new Care(code,(Animals)code, location, food, num, foodtime);
                    ANIMAL.SaveToFile(ANIMAL);
                    Animals[i] = ANIMAL;
                }
                for (int i = 0; i < Animals.Length; i++)
                {
                    Animals[i].SetFoodTime(Animals[i]);
                    Animals[i].SaveToFile(Animals[i]);
                }
                Care.AllInfo(Animals);
            }
        }
    }
}
