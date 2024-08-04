using System;
using System.IO;
using System.Linq;

namespace File
{
    class Program
    {
        public static void showFiles(string fileName1 , string fileName2 , bool writeFiles)
        {
            try
            {
                int counter1 = 0, counter2 = 0;
                StreamReader reader1 = new StreamReader(fileName1);
                StreamReader reader2 = new StreamReader(fileName2);
                StreamReader Counter1 = new StreamReader(fileName1);
                StreamReader Counter2 = new StreamReader(fileName2);
                //counting lines of first file
                while (Counter1.ReadLine() != null)
                    counter1++;
                //counting lines of second file
                while (Counter2.ReadLine() != null)
                    counter2++;
                if (writeFiles)
                {
                    //making name of file for writing
                    string LastFileName = fileName1.Remove(fileName1.Length - 4, 4) + fileName2.Remove(fileName2.Length - 4, 4) + ".txt";
                    StreamWriter writer = new StreamWriter(LastFileName);
                    //for writing both files line by line
                    int i = 0;
                    //writing files only in number of second file line
                    if (counter1 > counter2)
                    {
                        while (reader2.EndOfStream == false)
                        {
                            if (i % 2 == 0)
                            {
                                string file1Line = reader1.ReadLine();
                                writer.WriteLine(file1Line);
                                Console.WriteLine(file1Line);
                            }
                            else
                            {
                                string file2Line = reader2.ReadLine();
                                writer.WriteLine(file2Line);
                                Console.WriteLine(file2Line);
                            }
                            i++;
                        }
                        writer.Close();
                    }
                    //writing files only in number of first file line
                    else
                    {
                        while (reader1.EndOfStream == false)
                        {
                            if (i % 2 == 0)
                            {
                                string file1Line = reader1.ReadLine();
                                writer.WriteLine(file1Line);
                                Console.WriteLine(file1Line);
                            }
                            else
                            {
                                string file2Line = reader2.ReadLine();
                                writer.WriteLine(file2Line);
                                Console.WriteLine(file2Line);
                            }
                            i++;
                        }
                        writer.Close();
                    }
                }
                else
                {
                    int i = 0;
                    //writing files only in number of second file line
                    if (counter1 > counter2)
                    {
                        while (reader2.EndOfStream == false)
                        {
                            if (i % 2 == 0)
                            {
                                string file1Line = reader1.ReadLine();
                                Console.WriteLine(file1Line);
                            }
                            else
                            {
                                string file2Line = reader2.ReadLine();
                                Console.WriteLine(file2Line);
                            }
                            i++;
                        }
                    }
                    //writing files only in number of first file line
                    else
                    {
                        while (reader1.EndOfStream == false)
                        {
                            if (i % 2 == 0)
                            {
                                string file1Line = reader1.ReadLine();
                                Console.WriteLine(file1Line);
                            }
                            else
                            {
                                string file2Line = reader2.ReadLine();
                                Console.WriteLine(file2Line);
                            }
                            i++;
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("formats of files was incorect.try again with this format : --name.txt--.");
                string file1 = Console.ReadLine();
                string file2 = Console.ReadLine();
                showFiles(file1,file2,initializingBoolean());
            }
        }
        static void initializingFilename(ref string file1 , ref string file2)
        {
            Console.WriteLine("enter name of first file in --name.txt--format");
            string file1Name = Console.ReadLine();
            file1 = file1Name;
            Console.WriteLine("enter name of second file in --name.txt--format");
            string file2Name = Console.ReadLine();
            file2 = file2Name;
        }
        public static bool initializingBoolean()
        {
                bool boolean = false;
                Console.WriteLine("do yo want to save information or not ? answer by --yes-- or --no--");
                string answer = Console.ReadLine();
                if (answer == "no")
                { 
                    boolean = false;
                    return boolean;
                }
                if (answer == "yes")
                { 
                    boolean = true;
                    return boolean;
                }
                if(answer!="yes" && answer!="no")
                { 
                    Console.WriteLine("incoorect input. --yes-- or --no-- .");
                    initializingBoolean();
                }
                return false;
        }
        static void Main(string[] args)
        {
            string file1 ="", file2 = "";
            initializingFilename(ref file1, ref file2);
            showFiles(file1, file2, initializingBoolean());
        }
    }
}
