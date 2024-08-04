using System;
using System.Collections.Generic;
using System.IO;

namespace Quiz2
{
    class Passenger
    {
        public string LastName;
        public string PersonalityNumbre;
        public int YearOfBirth;
        public int DateOfOrder;
        public int ChairNumber;
        public int DateOfComback;
        public int DaysOfReamain;
        public int ticketCost;
        public enum PassengreKind { VIP,Normal};
        public PassengreKind P_Kind;
        public Passenger(string lastname , string personalitynumber , int birth_year , int order_date , int remain_days)
        {
            this.LastName = lastname;
            this.PersonalityNumbre = personalitynumber;
            this.YearOfBirth = birth_year;
            this.DateOfOrder = order_date;
            this.DaysOfReamain = remain_days;
        }
        public void SetPassengerType()
        {
            char[] PN_Array = new char[this.PersonalityNumbre.Length];
            PN_Array = this.PersonalityNumbre.ToCharArray();
            if ((PN_Array[0] == 0 && PN_Array[1] == 0) || (PN_Array[PN_Array.Length - 1] == 0 && PN_Array[PN_Array.Length - 2] == 0))
                this.P_Kind = PassengreKind.Normal;
            else
                this.P_Kind = PassengreKind.Normal;
        }
        public void SeatNumber()
        {
            int age = 98 - this.YearOfBirth;
            Random generator = new Random();
            if (this.P_Kind == PassengreKind.VIP)
            {
                if (age <= 40)
                    this.ChairNumber = generator.Next(100, 105);
                else
                    this.ChairNumber = generator.Next(106, 110);
            }
            if(this.P_Kind == PassengreKind.Normal)
            {
                if (age <= 25)
                    this.ChairNumber = generator.Next(111, 115);
                else
                    this.ChairNumber = generator.Next(116, 119);
            }
        }
        public void ReturnDate()
        {
            int[] token1 = new int[2];
            int token2 = this.DateOfOrder;
            int token3;
            int token4;
            int token5;
            for (int i = 1; i>=0; i--)
            {
                token3 = token2 % 10;
                token1[i] = token3;
                token2 = token2 / 10;
            }
            token4 = token1[0] * 10 + token1[1];
            if (token4 + this.DaysOfReamain > 30)
            {
                token5 = 30 - token4;
                this.DateOfComback = this.DateOfOrder + 100 - token4 + token5;
            }
            else
                this.DateOfComback = this.DateOfOrder + this.DaysOfReamain;

        }
        public void Cost(int KindeOfCost)
        {
            int cost=0;
            if (KindeOfCost == 1 && this.P_Kind == PassengreKind.VIP)
                cost = 1000;
            if (KindeOfCost == 1 && this.P_Kind == PassengreKind.Normal)
                cost = 200;
            if (KindeOfCost == 2 && this.P_Kind == PassengreKind.VIP)
                cost = 3000;
            if (KindeOfCost == 2 && this.P_Kind == PassengreKind.Normal)
                cost = 1500;
            this.ticketCost = cost;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numbresOfpassengre=0;
            bool boolean = true;
            List<int> chairNums = new List<int>();
            while(boolean)
            {
                Console.WriteLine("please enter the file name.");
                string filename = Console.ReadLine();
                Console.WriteLine("please enter the number between 1 , 2 , -1 ");
                int input = int.Parse(Console.ReadLine());
                string[] informations = new string[5];
                if (input != -1)
                {
                    StreamReader reader = new StreamReader(filename);
                    string line = reader.ReadLine();
                    informations = line.Split(",");
                    Passenger myPassengre = new Passenger(informations[0], informations[1], int.Parse(informations[2]), int.Parse(informations[3]), int.Parse(informations[4]));
                    myPassengre.Cost(input);
                    myPassengre.ReturnDate();
                    myPassengre.SeatNumber();
                    myPassengre.SetPassengerType();
                    chairNums.Add(myPassengre.ChairNumber);
                    StreamWriter writer = new StreamWriter($"outeput + {myPassengre.PersonalityNumbre}.txt");
                    Console.WriteLine($"family name : {myPassengre.LastName}");
                    Console.WriteLine($"type : {myPassengre.P_Kind}");
                    Console.WriteLine($"seat number : {myPassengre.ChairNumber}");
                    Console.WriteLine($"return date : {myPassengre.DateOfComback}");
                    Console.WriteLine($"cost : {myPassengre.ticketCost}");
                    numbresOfpassengre++;
                    boolean = true;
                }
                else
                    boolean = false;
                    break;
            }
            Console.WriteLine(numbresOfpassengre);
            for(int i = 0; i < chairNums.Count; i++)
            {
                Console.WriteLine(chairNums[i]);
            }
        }
    }
}
