using System;
using System.Collections.Generic;
using System.IO;

namespace BookStore
{
    class Program
    {
        public static void SaveToFile(Books Book)
        {
            File.AppendAllText("BookList.txt",$"{Book.name},");
            File.AppendAllText("BookList.txt", $"{Book.ID},");
            File.AppendAllText("BookList.txt", $"{Book.price},");
            File.AppendAllText("BookList.txt", $"{Book.publisher},");
            File.AppendAllText("BookList.txt", $"{Book.writer}");
            File.AppendAllText("BookList.txt", $"\n");
        }
        public struct Books
        {
            public string name;
            public string writer;
            public int price;
            public int ID;
            public string publisher;
            public Books(string name, string writer, int price, int ID, string publisher)
            {
                this.price = price;
                this.ID = ID;
                this.name = name;
                this.publisher = publisher;
                this.writer = writer;
            }
        }
        public static int initPrice()
        {
            int price = 0;
            try
            {
                Console.WriteLine("Please enter the price of book.");
                price = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("incorect input.Price must be integer.");
                initPrice();
            }
            return price ;
        }
        public static int initID()
        {
            int ID = 0;
            try
            {
                Console.WriteLine("Please enter the ID of book.");
                ID = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("incorect input.Price must be integer.");
                initID();
            }
            return ID;
        }
        public static int initIDforSearch()
        {
            int ID = 0;
            try
            {
                Console.WriteLine("Enter the ID of book.");
                ID = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("incorect input.Price must be integer.");
                initID();
            }
            return ID;
        }
        public static int initIDforDelete()
        {
            int ID = 0;
            try
            {
                Console.WriteLine("Please enter id of the book you want to be deleted");
                ID = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("incorect input.Price must be integer.");
                initID();
            }
            return ID;
        }
        public static void ADD(List<Books> myBooks)
        {
            Console.WriteLine("Please enter the name of book.");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter the writer of book.");
            string writer = Console.ReadLine();
            Console.WriteLine("Please enter the publisher of book.");
            string publisher = Console.ReadLine();
            Books Book = new Books(name, writer, initPrice() , initID() , publisher);
            string[] LINES = new string[5];
            List<string> IDs = new List<string>();
            if (myBooks.Count == 0)
            {
                myBooks.Add(Book);
                SaveToFile(Book);
            }
            else
            {
                bool boolean = true;
                string line="";
                StreamReader reader = new StreamReader("BookList.txt");
                while (reader.EndOfStream==false)
                {
                    line = reader.ReadLine();
                    LINES = line.Split(",");
                    IDs.Add(LINES[1]);
                }
                reader.Close();
                for (int i = 0; i < IDs.Count; i++)
                {
                    if (!IDs.Contains(Book.ID.ToString()))
                    {
                        boolean = false;
                    }
                    else
                    {
                        Console.WriteLine("This book already exist");
                        break;
                    }
                }
                if (!boolean)
                {
                    myBooks.Add(Book);
                    SaveToFile(Book);
                }
            }
           
        }
        public static void LIST()
        {
            StreamReader reader = new StreamReader("BookList.txt");
            while (reader.EndOfStream==false)
            {
                Console.WriteLine(reader.ReadLine());
            }
            reader.Close();
        }
        public static void SEARCH()
        {
            int ID = initIDforSearch();
            string line = "";
            string[] LINES = new string[5];
            List<string> IDs = new List<string>();
            StreamReader reader1 = new StreamReader("BookList.txt");
            StreamReader reader2 = new StreamReader("BookList.txt");
            int counter = 0;
            while (reader1.EndOfStream == false)
            {
                line = reader1.ReadLine();
                LINES = line.Split(",");
                IDs.Add(LINES[1]);
            }
            reader1.Close();
            if (IDs.Contains(ID.ToString()))
            {
                int index = IDs.IndexOf(ID.ToString());
                while (reader2.EndOfStream == false)
                {
                    string targetLine = reader2.ReadLine();
                    if (index == counter)
                        Console.WriteLine(targetLine);
                    counter++;
                }
                reader2.Close();
            }
            else
                Console.WriteLine("Not found");
        }
        public static void SORT()
        {
            try
            {
                Console.WriteLine("1 : SORTBYNAME - 2 : SORTBYID . Enter one of the numbers.");
                string input = Console.ReadLine();
                if (input == "1")
                    SORTBYNAME();
                if (input == "2")
                    SORTBYID();
            }
            catch
            {
                Console.WriteLine("incorect input");
                SORT();
            }
        }
        private static void SORTBYID()
        {
            List<double> IDs = new List<double>();
            StreamReader reader = new StreamReader("BookList.txt");
            string line = "";
            string ID="";
            while (reader.EndOfStream == false)
            {
                line = reader.ReadLine();
                ID = line.Split(",")[1];
                IDs.Add(Convert.ToDouble(ID));
            }
            reader.Close();
            Sort(ref IDs);
            foreach (double element in IDs)
                Console.WriteLine($"{element}");
        }
        private static void SORTBYNAME()
        {
            List<string> Names = new List<string>();
            List<string> sortedNames = new List<string>();
            StreamReader reader = new StreamReader("BookList.txt");
            string line = "";
            string name;
            while (reader.EndOfStream == false)
            {
                line = reader.ReadLine();
                name = line.Split(",")[0];
                Names.Add(name);
            }
            reader.Close();
            Names.Sort();
            foreach (string element in Names)
                Console.WriteLine($"{element}");
        }
        public static void Sort(ref List<double> arr)
        {
            int i, j, minIndex;
            double tmp;
            int n = arr.Count;
            for (i = 0; i < n - 1; i++)
            {
                minIndex = i;
                for (j = i + 1; j < n; j++)
                    if (arr[j] < arr[minIndex])
                        minIndex = j;
                if (minIndex != i)
                {
                    tmp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = tmp;
                }
            }
        }
        static void DELETE(List<Books> myBooks)
        {
            int ID = initIDforDelete();
            string line = "";
            string[] LINES = new string[5];
            List<string> IDs = new List<string>();
            StreamReader reader1 = new StreamReader("BookList.txt");
            StreamReader reader2 = new StreamReader("BookList.txt");
            StreamWriter writer = new StreamWriter("UpdatedBookList.txt");
            while (reader1.EndOfStream == false)
            {
                line = reader1.ReadLine();
                LINES = line.Split(",");
                if (LINES[1] == ID.ToString())
                {
                    string deletedLine = line;
                    while (reader2.EndOfStream==false)
                    {
                        string otherLines = reader2.ReadLine();
                        if (otherLines !=deletedLine)
                            writer.WriteLine(otherLines);
                    }
                    writer.Close();
                }
            }
        }
        public static void EXITE()
        {
            Console.WriteLine("Program has been finished");
        }
        public static void Menu()
        {
            List<Books> BOOKS = new List<Books>();
            bool boolean = true;
            while (boolean)
            {
                Console.WriteLine("choose --ADD-- or --LIST-- or --SEARCH-- or --DELETE-- or --SORT-- or --EXITE--");
                string input = Console.ReadLine();
                if (input.ToLower() == "add")
                    ADD(BOOKS);
                if (input.ToLower() == "list")
                    LIST();
                if (input.ToLower() == "search")
                    SEARCH();
                if (input.ToLower() == "delete")
                    DELETE(BOOKS);
                if (input.ToLower() == "sort")
                    SORT();
                if (input.ToLower() == "exite")
                {
                    EXITE();
                    boolean = false;
                }
                if (input.ToLower() != "add" && input.ToLower() != "list" && input.ToLower() != "search" && input.ToLower() != "delete" && input.ToLower() != "sort" && input.ToLower() != "exite")
                {
                    Console.WriteLine("incorect input");
                    Menu();
                }
            }
        }
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter("BookList.txt");
            writer.Close();
            Menu();
        }
    }
}
