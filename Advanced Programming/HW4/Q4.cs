using System;
using System.Collections.Generic;
using System.IO;

namespace Files2
{
    class Program
    {
        public static string FileName;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the file name");
            string filename = Console.ReadLine();
            FileName = filename;
            BlankToStar();
            CountNumbersAndVowels();
        }

        private static void CountNumbersAndVowels()
        {
            char chr;
            int numbers = 0;
            int vowels = 0;
            StreamReader reader = new StreamReader(FileName);

            while (reader.EndOfStream == false)
            {
                chr = (char)reader.Read();
                if (chr == '1' || chr == '2' || chr == '3' || chr == '4' || chr == '5' || chr == '6' || chr == '7' || chr == '8' || chr == '9' || chr == '0')
                    numbers++;
                if (chr == 'a' || chr == 'o' || chr == 'e' || chr == 'u' || chr == 'i')
                    vowels++;
            }
            Console.WriteLine("nuumbers : {0}", numbers);
            Console.WriteLine("vowels : {0}", vowels);
        }
        private static void BlankToStar()
        {
            StreamReader reader = new StreamReader(FileName);
            StreamWriter writer = new StreamWriter("final.txt");
            string[] fileInformation;
            int lines = 0;
            int stars = 0;
            while (reader.EndOfStream == false)
            {
                string line = reader.ReadLine();
                fileInformation = line.Split(" ");
                for(int i = 0; i < fileInformation.Length-1; i++)
                {
                    writer.Write($"{fileInformation[i]}*");
                }
                writer.Write($"{fileInformation[fileInformation.Length - 1]}");
                writer.Write("\n");
                lines++;
                stars += fileInformation.Length - 1;
            }
            writer.Close();
            Console.WriteLine("stars : {0} ", stars);
            Console.WriteLine("lines : {0} ", lines);
        }
    }
}
