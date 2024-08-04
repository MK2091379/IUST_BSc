using System;
using System.IO;

namespace FinalExam3
{
    class goods<T>
    {
        private readonly object stream;
        int price;
        string path;
        bool existence;
        public goods(int price,string path,bool existence)
        {
            this.price = price;
            this.existence = existence;
            if (this.existence == true)
                this.path = path;
            else
            {
                this.path = null;
                Console.WriteLine("this good doesnt exists");
            }
            
        }
        public virtual void info<T>()
        {
            string info = File.ReadAllText(this.path);
            Console.WriteLine(info);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
