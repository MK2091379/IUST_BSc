using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace BookStroreDevelopment
{
    class Person
    {
        protected string UserName;
        protected string variableField;
        public Person(string username , string variablefield)
        {
            this.UserName = username;
            this.variableField = variablefield;
        }
        public Person()
        {

        }
    }
    public class SaveToFile
    {
        public static void saveTOfile<T1 , T2>(T1 input1 , T2 input2)
        {
            File.AppendAllText($"CustomersInfo.txt", $"{input1}");
            File.AppendAllText($"CustomersInfo.txt", $"\n");
            File.AppendAllText($"CustomersInfo.txt", $"{input2}");
            File.AppendAllText($"CustomersInfo.txt", $"\n");
            File.AppendAllText($"CustomersInfo.txt", $"-----------------------------");
            File.AppendAllText($"CustomersInfo.txt", $"\n");
        }
    }
    class Seller:Person
    {
        public Seller(string username , string password) : base(username,password)
        {
            this.UserName = username;
            this.variableField = password;
        }
        public string USERNAME
        {
            get
            {
                return this.UserName;
            }
            private set
            {
                this.UserName = value;
            }
        }
        public string PASSWORD
        {
            get
            {
                return this.variableField;
            }
            private set
            {
                this.variableField = value;
            }
        }
        public static bool CheckEmailFormat(string emailAddress)
        {
            string patternStrict = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            System.Text.RegularExpressions.Regex reStrict = new System.Text.RegularExpressions.Regex(patternStrict);
            bool isStrictMatch = reStrict.IsMatch(emailAddress);
            return isStrictMatch;
        }
    }
    class Student:Person
    {
        public Student()
        {

        }
        public Student(string username , string id):base(username,id)
        {
            this.UserName = username;
            this.variableField = id;
        }
        public string USERNAME
        {
            get
            {
                return this.UserName;
            }
            private set
            {
                this.UserName = value;
            }
        }
        public string publicID
        {
            get
            {
                return this.variableField;
            }
            private set
            {
                this.variableField = value;
            }
        }
        public static bool CheckIDFormat(string ID)
        {
            string patternStrict = @"^([9]{1})([0-9]{7})$";
            System.Text.RegularExpressions.Regex reStrict = new System.Text.RegularExpressions.Regex(patternStrict);
            bool isStrictMatch = reStrict.IsMatch(ID);
            if (ID.Length == 8 && isStrictMatch == true)
                isStrictMatch = true;
            else
                isStrictMatch = false;
            return isStrictMatch;
        }
    }
    class Teacher : Person
    {
        public Teacher()
        {

        }
        public Teacher(string username, string school):base(username,school)
        {
            this.UserName = username;
            this.variableField = school;
        }
        public string USERNAME
        {
            get
            {
                return this.UserName;
            }
            private set
            {
                this.UserName = value;
            }
        }
        public string SCHOOL
        {
            get
            {
                return this.variableField;
            }
            private set
            {
                this.variableField = value;
            }
        }
    }
    class Customer: Person
    {
        public Customer()
        {

        }
        public Customer(string username, string personalID) : base(username, personalID)
        {
            this.UserName = username;
            this.variableField = personalID;
        }
        public string USERNAME
        {
            get
            {
                return this.UserName;
            }
            private set
            {
                this.UserName = value;
            }
        }
        public string PERSONALID
        {
            get
            {
                return this.variableField;
            }
            private set
            {
                this.variableField = value;
            }
        }
    }
    static class CheckPersonalID
    {
        public static bool checkPersonalID(this string str)
        {
            bool boolean = true;
            try
            {
                double a, b, c;
                a = Char.GetNumericValue(str[9]);
                b = Char.GetNumericValue(str[0]) * 10 + Char.GetNumericValue(str[1]) * 9 + Char.GetNumericValue(str[2]) * 8 + Char.GetNumericValue(str[3]) * 7 + Char.GetNumericValue(str[4]) * 6 + Char.GetNumericValue(str[5]) * 5 + Char.GetNumericValue(str[6]) * 4 + Char.GetNumericValue(str[7]) * 3 + Char.GetNumericValue(str[8]) * 2;
                c = b % 11;
                if ((c == 0 && a == c) || (c == 1 && a == 1) || (c > 1 && a == Math.Abs(c - 11)))
                {
                    Console.WriteLine("corect");
                    boolean = true;
                }
                else
                {
                    Console.WriteLine("wrong");
                    boolean = false;
                }
                if (Convert.ToInt32(str) % 11 == 0)
                {
                    Console.WriteLine("your personalID is in bad format");
                    boolean = false;
                }
                return boolean;
            }
            catch
            {
                Console.WriteLine("your personalID is in bad format");
                boolean = false;
                return boolean;
            }
        } 
    }
    class Media
    {
        protected string MediaName;
        protected double Price;
        protected int MediaID;
        public Media(string medianame, double price , int mediaID)
        {
            this.MediaID = mediaID;
            this.MediaName = medianame;
            this.Price = price;
        }
        public string MEDIANAME
        {
            get
            {
                return this.MediaName;
            }
            private set
            {
                this.MediaName = value;
            }
        }
        public int MEDIAID
        {
            get
            {
                return this.MediaID;
            }
            private set
            {
                this.MediaID = value;
            }
        }
        public double PRICE
        {
            get
            {
                return this.Price;
            }
            private set
            {
                this.Price = value;
            }
        }
    }
    class Book:Media
    {
        private string Publisher;
        private string Writer;
        public Book(string name , double price , int ID , string writername , string publisher) : base(name, price, ID)
        {
            this.MediaID = ID;
            this.MediaName = name;
            this.Price = price;
            this.Publisher = publisher;
            this.Writer = writername;
        }
        public string WRITER
        {
            get
            {
                return this.Writer;
            }
            private set
            {
                this.Writer = value;
            }
        }
        public string PUBLISHER
        {
            get
            {
                return this.Publisher;
            }
            private set
            {
                this.Publisher = value;
            }
        }
        public double realPrice()
        {
            return Convert.ToDouble(this.Price) + Convert.ToDouble(this.Price / 10);
        }
    }
    class Video:Media
    {
        private int CD_Nums;
        private int Time;
        public Video(string name, double price, int ID, int time, int cd_nums) : base(name, price, ID)
        {
            this.MediaID = ID;
            this.MediaName = name;
            this.Price = price;
            this.CD_Nums = cd_nums;
            this.Time = time;
        }
        public int CD_NUMS
        {
            get
            {
                return this.CD_Nums;
            }
            private set
            {
                this.CD_Nums = value;
            }
        }
        public int TIME
        {
            get
            {
                return this.Time;
            }
            private set
            {
                this.Time = value;
            }
        }
        public double realPrice()
        {
            return this.Price + (this.Price*0.03*this.CD_Nums) + Convert.ToDouble(this.Time/60)*0.05;
        }
    }
    class Magazines : Media
    {
        private int Pages;
        private string Publisher;
        public Magazines(string name, double price, int ID, string publisher, int pages) : base(name, price, ID)
        {
            this.MediaID = ID;
            this.MediaName = name;
            this.Price = price;
            this.Publisher = publisher;
            this.Pages = pages;
        }
        public int PAGES
        {
            get
            {
                return this.Pages;
            }
            private set
            {
                this.Pages = value;
            }
        }
        public string PUBLISHER
        {
            get
            {
                return this.Publisher;
            }
            private set
            {
                this.Publisher = value;
            }
        }
        public double realPrice()
        {
            double price = 0;
            if (this.Pages >= 1 && this.Pages <= 20)
                price = this.Price + this.Price * 0.02;
            if (this.Pages >= 21 && this.Pages <= 50)
                price = this.Price + this.Price * 0.03;
            return price;
        }
    }
    abstract class Library
    {
        public static bool isIDexist(Media media)
        {
            bool output = true;
            StreamReader reader = new StreamReader("Library.txt");
            int lineCounter = 1;
            List<string> IDs = new List<string>();
            while (reader.EndOfStream == false)
            {
                if (lineCounter % 6 == 1)
                {
                    IDs.Add(reader.ReadLine());
                }
                lineCounter++;
            }
            reader.Close();
            if (IDs.Contains(media.MEDIAID.ToString()))
                output = true;
            else
                output = false;
            return output;
        }
        public static void ADD<T>(T media)
        {
            if(media is Book)
            {
                Book book = media as Book;
                if (isIDexist(book) == false)
                {
                    File.AppendAllText("Library.txt", $"{book.MEDIAID}");
                    File.AppendAllText("Library.txt", $"\n");
                    File.AppendAllText("Library.txt", $"{book.MEDIANAME}");
                    File.AppendAllText("Library.txt", $"\n");
                    File.AppendAllText("Library.txt", $"{book.PRICE}");
                    File.AppendAllText("Library.txt", $"\n");
                    File.AppendAllText("Library.txt", $"{book.PUBLISHER}");
                    File.AppendAllText("Library.txt", $"\n");
                    File.AppendAllText("Library.txt", $"{book.WRITER}");
                    File.AppendAllText("Library.txt", $"\n");
                    File.AppendAllText("Library.txt", $"-------------------------");
                    File.AppendAllText("Library.txt", $"\n");
                }
                else
                    Console.WriteLine("this media exists in library");
            }
            if (media is Video)
            {
                Video video = media as Video;
                if (isIDexist(video) == false)
                {
                    File.AppendAllText("Library.txt", $"{video.MEDIAID}");
                    File.AppendAllText("Library.txt", $"\n");
                    File.AppendAllText("Library.txt", $"{video.MEDIANAME}");
                    File.AppendAllText("Library.txt", $"\n");
                    File.AppendAllText("Library.txt", $"{video.PRICE}");
                    File.AppendAllText("Library.txt", $"\n");
                    File.AppendAllText("Library.txt", $"{video.TIME}");
                    File.AppendAllText("Library.txt", $"\n");
                    File.AppendAllText("Library.txt", $"{video.CD_NUMS}");
                    File.AppendAllText("Library.txt", $"\n");
                    File.AppendAllText("Library.txt", $"-------------------------");
                    File.AppendAllText("Library.txt", $"\n");
                }
                else
                    Console.WriteLine("this media exists in library");
            }
            if (media is Magazines)
            {
                Magazines magazines = media as Magazines;
                if (isIDexist(magazines) == false)
                {
                    File.AppendAllText("Library.txt", $"{magazines.MEDIAID}");
                    File.AppendAllText("Library.txt", $"\n");
                    File.AppendAllText("Library.txt", $"{magazines.MEDIANAME}");
                    File.AppendAllText("Library.txt", $"\n");
                    File.AppendAllText("Library.txt", $"{magazines.PRICE}");
                    File.AppendAllText("Library.txt", $"\n");
                    File.AppendAllText("Library.txt", $"{magazines.PUBLISHER}");
                    File.AppendAllText("Library.txt", $"\n");
                    File.AppendAllText("Library.txt", $"{magazines.PAGES}");
                    File.AppendAllText("Library.txt", $"\n");
                    File.AppendAllText("Library.txt", $"-------------------------");
                    File.AppendAllText("Library.txt", $"\n");
                }
                else
                    Console.WriteLine("this media exists in library");
            }
        }
        public static void SEARCH(string ID)
        {
            List<string> fileInformation = new List<string>();
            StreamReader reader = new StreamReader("Library.txt");
            while(reader.EndOfStream == false)
                fileInformation.Add(reader.ReadLine());
            reader.Close();
            bool isExist = false;
            for(int i = 0; i < fileInformation.Count; i++)
            {
                if (ID == fileInformation[i])
                {
                    Console.WriteLine(fileInformation[i] + " - " + fileInformation[i + 1] + " - " + fileInformation[i + 2] + " - " + fileInformation[i + 3] + " - " + fileInformation[i + 4]);
                    isExist = true;
                }
            }
            if(isExist == false)
            {
                Console.WriteLine("don't exist");
            }
        }
        public static void DELETE(string ID)
        {
            List<string> fileInformation = new List<string>();
            StreamReader reader = new StreamReader("Library.txt");
            while (reader.EndOfStream == false)
                fileInformation.Add(reader.ReadLine());
            reader.Close();
            if (!fileInformation.Contains(ID))
                Console.WriteLine("doesn't exist");
            for (int i = 0; i < fileInformation.Count; i++)
            {
                if (ID == fileInformation[i])
                {
                    fileInformation.RemoveRange(i, 6);
                }
            }

            StreamWriter writer = new StreamWriter("Library.txt");
            foreach (var element in fileInformation)
                writer.WriteLine(element);
            writer.Close();
        }
    }
    class Program
    {
        public static void shopingWorks(Person shoperKinde)
        {
            List<object> shopBox = new List<object>();
            List<string> fileInformation = new List<string>();
            StreamReader otherReader = new StreamReader("Library.txt");
            while (otherReader.EndOfStream == false)
            {
                fileInformation.Add(otherReader.ReadLine());
            }
            List<string> priceList = new List<string>();
            Console.WriteLine("please enter name");
            string name = Console.ReadLine();
            if (shoperKinde is Student)
            {
                Console.WriteLine("please enter ID");
                string ID = Console.ReadLine();
                if (Student.CheckIDFormat(ID))
                {
                    Student student = new Student(name, ID);
                    SaveToFile.saveTOfile<string, string>(name, ID);
                }
                else
                {
                    do
                    {
                        Console.WriteLine("incorect ID.try again");
                        ID = Console.ReadLine();
                    } while (Student.CheckIDFormat(ID) == false);
                    SaveToFile.saveTOfile<string, string>(name, ID);
                }
            }
            if (shoperKinde is Teacher)
            {
                Console.WriteLine("please enter school");
                string school = Console.ReadLine();
                Teacher teacher = new Teacher(name, school);
                SaveToFile.saveTOfile<string, string>(name, school);
            }
            if (shoperKinde is Customer)
            {
                Console.WriteLine("please enter ID");
                string ID = Console.ReadLine();
                if (ID.checkPersonalID())
                {
                    Customer customer = new Customer(name, ID);
                    SaveToFile.saveTOfile<string, string>(name, ID);
                }
                else
                {
                    do
                    {
                        Console.WriteLine("incorect ID.try again");
                        ID = Console.ReadLine();
                    } while (ID.checkPersonalID() == false);
                    SaveToFile.saveTOfile<string, string>(name, ID);
                }
            }
            bool boolean4 = true;
            while (boolean4)
            {
                int indexofBook=0;
                Console.WriteLine("please choose --select-- or --edite-- or --buy-- or --chance-- or --exite--");
                string customerInput = Console.ReadLine();
                if (customerInput.ToLower() == "select")
                {
                    StreamReader reader = new StreamReader("Library.txt");
                    while (reader.EndOfStream == false)
                        Console.WriteLine(reader.ReadLine());
                    reader.Close();
                    Console.WriteLine("enter the book name");
                    string bookName = Console.ReadLine();
                    if (fileInformation.Contains(bookName))
                    {
                        shopBox.Add(bookName);
                        indexofBook = shopBox.IndexOf(bookName);
                        priceList.Add(fileInformation[fileInformation.IndexOf(bookName) + 1]);
                    }
                    else
                        Console.WriteLine("dont exist");
                    if (shopBox.Count > 20)
                        Console.WriteLine("you are not allowed to add more than 20 item");
                }
                if (customerInput.ToLower() == "edit")
                {
                    Console.WriteLine("do you want delete some item?");
                    string answer = Console.ReadLine();
                    if (answer.ToLower() == "no")
                    {
                        Console.WriteLine("please enetr the name of book to show its price");
                        string bookName = Console.ReadLine();
                        if (fileInformation.Contains(bookName))
                        {
                            Console.WriteLine($"{fileInformation[fileInformation.IndexOf(bookName) + 1]}");
                        }
                        else
                        {
                            Console.WriteLine("don't exist");
                        }
                    }
                    if (answer.ToLower() == "yes")
                    {
                        Console.WriteLine("please enetr the name of book to delete from shopBox");
                        string bookName = Console.ReadLine();
                        if (shopBox.Contains(bookName))
                        {
                            shopBox.Remove(bookName);
                            priceList.Remove(priceList[indexofBook]);
                        }
                        else
                            Console.WriteLine("doesn't exist in shopbox");
                    }
                    if (answer.ToLower() != "yes" && answer.ToLower() != "no")
                    {
                        Console.WriteLine("incorect answer.press any button");
                        Console.ReadKey();
                    }
                }
                if (customerInput.ToLower() == "buy")
                {
                    double finalPrice = 0;
                    double discount = 0;
                    if(shoperKinde is Student)
                    {
                        discount = 0.2;
                    }
                    if(shoperKinde is Teacher)
                    {
                        if (shopBox.Count > 3)
                            discount = 0.15;
                        else
                            discount = 0;
                    }
                    if (shoperKinde is Customer)
                    {
                        if (shopBox.Count > 5)
                            discount = 0.05;
                        else
                            discount = 0;
                    }
                    foreach (var element in priceList)
                    {
                        finalPrice += Convert.ToDouble(element);
                    }
                    finalPrice = finalPrice - finalPrice * 0.2;
                    Console.WriteLine($"{finalPrice}");
                    shopBox = new List<object>();
                    priceList = new List<string>();
                }
                if (customerInput.ToLower() == "exite")
                {
                    boolean4 = false;
                }
                if (customerInput.ToLower() == "chance")
                {
                    List<double> RandomDiscountList = new List<double>() { 0.30, 0.25, 0.15, 0.10, 0.07, 0.05, 0.03, 0.02, 0.00 };
                    Random generate = new Random();
                    int RandomDiscountIndex = generate.Next(RandomDiscountList.Count);
                    double randomDiscount = RandomDiscountList[RandomDiscountIndex];
                    double finalPrice = 0;
                    foreach (var element in priceList)
                    {
                        finalPrice += Convert.ToDouble(element);
                    }
                    finalPrice = finalPrice - finalPrice * 0.2 - finalPrice * randomDiscount;
                    Console.WriteLine($"{finalPrice}");
                    shopBox = new List<object>();
                    priceList = new List<string>();
                }
                if(customerInput.ToLower()!="chance" && customerInput.ToLower() != "edit" && customerInput.ToLower() != "buy" && customerInput.ToLower() != "select" && customerInput.ToLower() != "exite")
                {
                    Console.WriteLine("incorect input.press any button");
                    Console.ReadKey();
                }
            }
        }
        public static string initName()
        {
            Console.WriteLine("please enter the name");
            string name = Console.ReadLine();
            return name;
        }
        public static double initPrice()
        {
            double price = 0;
            try
            {
                Console.WriteLine("please enter the price");
                price = int.Parse(Console.ReadLine());
            }
            catch
            {
                bool checking;
                do
                {
                    Console.WriteLine("incorect input.try again");
                    try
                    {
                        checking = true;
                        price = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        checking = false;
                    }
                } while (checking == false);
            }
            return price;
        }
        public static int initID()
        {
            int ID = 0;
            try
            {
                Console.WriteLine("please enter the ID");
                ID = int.Parse(Console.ReadLine());
            }
            catch
            {
                bool checking;
                do
                {
                    Console.WriteLine("incorect input.try again");
                    try
                    {
                        checking = true;
                        ID = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        checking = false;
                    }
                } while (checking == false);
            }
            return ID;
        }
        public enum access {admin,user,exite };
        static void Main(string[] args)
        {
            bool boolean1 = true;
            string accessType = "";
            string defaultPassword = "";
            int ProgramRunCounter = 1;
            while (boolean1)
            {
                Console.WriteLine("enter --admin-- or --user-- or --exite--");
                accessType = Console.ReadLine();
                if(accessType.ToLower() == access.admin.ToString().ToLower())
                {
                    if (ProgramRunCounter == 1)
                    {
                        defaultPassword = "MyShop1234";
                    }
                    Console.WriteLine("enter your email");
                    string email = Console.ReadLine();
                    Console.WriteLine("enter the password");
                    string password = Console.ReadLine();
                    Seller seller = new Seller(email, password);
                    if (Seller.CheckEmailFormat(seller.USERNAME))
                    {
                        
                    }
                    else
                    {
                        do
                        {
                            Console.WriteLine("incroct email.try again");
                            Console.WriteLine("enter your email");
                            email = Console.ReadLine();
                            Console.WriteLine("enter the password");
                            password = Console.ReadLine();
                        } while (Seller.CheckEmailFormat(email)==false);
                        seller = new Seller(email, password);
                    }
                    bool boolean2 = true;
                    while (boolean2)
                    {
                        if (seller.PASSWORD == defaultPassword)
                        {
                            Console.WriteLine("wplease choose --ADD-- or --DELETE-- or --SEARCH-- or --SHOWCUSTOMERS-- or --CHANGEPASS-- or --EXITE--");
                            string AdminPanelInput = Console.ReadLine();
                            if(AdminPanelInput.ToLower() == "add")
                            {
                                Console.WriteLine("do you want add book or magazine or video?");
                                string mediaKind = Console.ReadLine();
                                if (mediaKind.ToLower() == "book")
                                {
                                    Console.WriteLine("please enter the name of writer");
                                    string writer = Console.ReadLine();
                                    Console.WriteLine("please enter the publisher");
                                    string publisher = Console.ReadLine();
                                    Book book = new Book(initName(),initPrice(),initID(),writer, publisher);
                                    Book editedBook = new Book(book.MEDIANAME,book.realPrice() , book.MEDIAID, writer, publisher);
                                    Library.ADD<Book>(editedBook);
                                }
                                if (mediaKind.ToLower() == "video")
                                {
                                    int cd_nums = 0;
                                    int time = 0;
                                    try
                                    {
                                        Console.WriteLine("please enter the cd_nums");
                                        cd_nums = int.Parse(Console.ReadLine());
                                    }
                                    catch
                                    {
                                        bool checking;
                                        do
                                        {
                                            Console.WriteLine("incorect input.try again");
                                            try
                                            {
                                                checking = true;
                                                cd_nums = int.Parse(Console.ReadLine());
                                            }
                                            catch
                                            {
                                                checking = false;
                                            }
                                        } while (checking == false);
                                    }
                                    try
                                    {
                                        Console.WriteLine("please enter the time");
                                        time = int.Parse(Console.ReadLine());
                                    }
                                    catch
                                    {
                                        bool checking;
                                        do
                                        {
                                            Console.WriteLine("incorect input.try again");
                                            try
                                            {
                                                checking = true;
                                                time = int.Parse(Console.ReadLine());
                                            }
                                            catch
                                            {
                                                checking = false;
                                            }
                                        } while (checking == false);
                                    }
                                    Video video = new Video(initName(), initPrice(), initID(), time, cd_nums);
                                    Video editedVideo = new Video(video.MEDIANAME, video.realPrice(), video.MEDIAID, time, cd_nums);
                                    Library.ADD<Video>(editedVideo);
                                }
                                if (mediaKind.ToLower() == "magazine")
                                {
                                    int pages = 0;
                                    try
                                    {
                                        Console.WriteLine("please enter the name of writer");
                                        pages = int.Parse(Console.ReadLine());
                                    }
                                    catch
                                    {
                                        bool checking;
                                        do
                                        {
                                            Console.WriteLine("incorect input.try again");
                                            try
                                            {
                                                checking = true;
                                                pages = int.Parse(Console.ReadLine());
                                            }
                                            catch
                                            {
                                                checking = false;
                                            }
                                        } while (checking == false);
                                    }
                                    Console.WriteLine("please enter the publisher");
                                    string publisher = Console.ReadLine();
                                    Magazines magazines = new Magazines(initName(), initPrice(), initID(),publisher,pages);
                                    Magazines editedMagazine = new Magazines(magazines.MEDIANAME, magazines.realPrice(), magazines.MEDIAID, publisher, pages);
                                    Library.ADD<Magazines>(editedMagazine);
                                }
                                if (mediaKind.ToLower() != "magazine" && mediaKind.ToLower() != "book" && mediaKind.ToLower() != "video")
                                {
                                    bool DoWhilecheck = false;
                                    do
                                    {
                                        Console.WriteLine("incorect input.press any button");
                                        Console.ReadKey();
                                        DoWhilecheck = true;
                                    } while (DoWhilecheck ==false);
                                }
                            }
                            if (AdminPanelInput.ToLower() == "delete")
                            {
                                Console.WriteLine("enter the id");
                                string ID = Console.ReadLine();
                                Library.DELETE(ID);
                            }
                            if (AdminPanelInput.ToLower() == "search")
                            {
                                Console.WriteLine("enter the id");
                                string ID = Console.ReadLine();
                                Library.SEARCH(ID);
                            }
                            if (AdminPanelInput.ToLower() == "showcustomers")
                            {
                                StreamReader reader = new StreamReader("CustomersInfo.txt");
                                while (reader.EndOfStream == false)
                                    Console.WriteLine(reader.ReadLine());
                                reader.Close();
                            }
                            if (AdminPanelInput.ToLower() == "changepass")
                            {
                                DateTime changeTime = new DateTime();
                                changeTime = DateTime.Now;
                                List<string> ChangePassTime = new List<string>();
                                StreamReader reader = new StreamReader("Time.txt");
                                while (reader.EndOfStream == false)
                                {
                                    ChangePassTime.Add(reader.ReadLine());
                                }
                                reader.Close();
                                if (ChangePassTime.Count != 0)
                                {
                                    Console.WriteLine($"last change : {ChangePassTime[ChangePassTime.Count - 1]}");
                                }
                                Console.WriteLine("please wnter new password");
                                string newPass = Console.ReadLine();
                                defaultPassword = newPass;
                                File.AppendAllText("Time.txt", $"{changeTime.ToShortDateString()} - {changeTime.ToShortTimeString()}");
                                File.AppendAllText("Time.txt", "\n");
                                boolean2 = false;
                                ProgramRunCounter++;
                            }
                            if (AdminPanelInput.ToLower() == "exite")
                            {
                                boolean2 = false;
                            }
                            if(AdminPanelInput.ToLower()!= "add" && AdminPanelInput.ToLower() != "search" && AdminPanelInput.ToLower() != "delete" && AdminPanelInput.ToLower() != "showcustomers" && AdminPanelInput.ToLower() != "changepass" && AdminPanelInput.ToLower() != "exite")
                            {
                                bool DoWhilecheck = false;
                                do
                                {
                                    Console.WriteLine("incorect input.press any button");
                                    Console.ReadKey();
                                    DoWhilecheck = true;
                                } while (DoWhilecheck == false);
                            }
                        }
                        else
                        {
                            do
                            {
                                Console.WriteLine("incorect password.try again");
                                password = Console.ReadLine();
                                seller = new Seller(email, password);
                            } while (seller.PASSWORD != defaultPassword);
                        }
                    }
                    
                }
                if (accessType == access.user.ToString().ToLower())
                {
                    bool boolean3 = true;
                    while (boolean3)
                    {
                        Console.WriteLine("please enter --student-- or --teacher-- or --otherPeople-- or --exite--");
                        string userType = Console.ReadLine();
                        if (userType == "student".ToLower())
                        {
                            Student s = new Student();
                            Program.shopingWorks(s);
                        }
                        if (userType.ToLower() == "teacher".ToLower())
                        {
                            Teacher t = new Teacher();
                            Program.shopingWorks(t);
                        }
                        if (userType.ToLower() == "otherpeople".ToLower())
                        {
                            Customer c = new Customer();
                            Program.shopingWorks(c);
                        }
                        if(userType.ToLower() == "exite")
                        {
                            boolean3 = false;
                        }
                        if(userType.ToLower() != "student" && userType.ToLower() != "teacher" && userType.ToLower() != "exite" && userType.ToLower() != "otherpeople")
                        {
                            Console.WriteLine("incorect type of user.press any key");
                            Console.ReadKey();
                        }
                    }
                }
                if (accessType == access.exite.ToString().ToLower())
                {
                    boolean1 = false;
                }
                if (accessType != access.user.ToString().ToLower() && accessType != access.admin.ToString().ToLower() && accessType != access.exite.ToString().ToLower())
                {
                    bool accessTypeValue = false;
                    do
                    {
                        Console.WriteLine("incorect access type.try again.press any button");
                        Console.ReadKey();
                        accessTypeValue = true;
                    } while (accessTypeValue==false);
                }
            }
        }
    }
}
