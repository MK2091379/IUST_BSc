using System;
using static System.Math;

namespace FitnessClub
{
    public class FitnessClub
    {
        public string clubName;
        public string clubAddress;
        public int clubPopulation;
        public Member[] member = new Member[0];
        public int upcoming;
        public FitnessClub(string clubname , int upcoming)
        {
            this.clubName = clubname;
            this.upcoming = upcoming;
        }
        public FitnessClub(string clubname,string clubaddress,int clubpopulation,params Member[] members)
        {
            this.clubName = clubname;
            this.clubAddress = clubaddress;
            this.clubPopulation = clubpopulation;
            this.member = new Member[members.Length];
            
            for(int i=0,j=0;i<this.member.Length && j < members.Length; i++, j++)
            {
                this.member[i] = members[j];
            }
        }
        public void AddMember(params Member[] Members)
        {
            int token = clubPopulation;
            if (upcoming == 0 && token != 0)
            {
                Member[] temp = this.member;
                this.member = new Member[temp.Length + Members.Length];
                for (int i = 0; i < temp.Length; i++)
                {
                    this.member[i] = temp[i];
                }
                for (int i = temp.Length, j = 0; j < Members.Length && i < member.Length; j++, i++)
                {
                    this.member[i] = Members[j];
                    token--;
                }
            }
            if(upcoming!=0)
            {
                Console.WriteLine($"{upcoming} rooz mandeh be eftetah bashghah,nemitavanid ozv shavid");
            }
            if (member.Length > clubPopulation)
            {
                Console.WriteLine($"zarfiat bashghah {clubPopulation} nafar ast dar hali ke tedad alan {member.Length} nafar ast");
            }

        }
    }
    public class Member
    {
        public string name;
        public string lastname;
        public int ID;
        public long phoneNum;
        public double weight;
        public double height;
        public bool disease;
        public static int IDHolder=1000;
        public static int NextID()
        {
            Random generator = new Random();
            int x = generator.Next(1, 9);
            if (IDHolder != 1000)
                return IDHolder += x;
            else
                IDHolder++;
            return 1000;
        }
        public Member()
        {
            this.ID = NextID();
        }
        public Member(string name,string lastname,long phonnum,double weight,double height, bool disease)
        {
            this.name = name;
            this.lastname = lastname;
            this.ID = NextID();
            this.phoneNum = phonnum;
            this.weight = weight;
            this.height = height;
            this.disease = disease;
        }
        public bool VIPMember()
        {
            if ((Math.Sqrt(this.ID * 234165) - 15 + 2) % 2 == 0)
                return true;
            else
                return false;
        }
        private double CalculateBMI()
        {
            double token;
            token = this.weight / Pow(height, 2);
            return token;
        }
        public static void BMIResult(Member sombody)
        {
            double token = sombody.CalculateBMI();
            if (token < 18.5)
                Console.WriteLine("under weight");
            if (token >= 18.5 && token < 25)
                Console.WriteLine("normal weight");
            if (token >= 25 && token <= 29)
                Console.WriteLine("over weight");
            if(token>29)
                Console.WriteLine("Obesity");
            

        }
        public void countMembers(FitnessClub input)
        {
            int numbers;
            numbers = input.member.Length;
            Console.WriteLine($"tedad aza : {numbers}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool person1VIP, person2VIP;
            Console.WriteLine("person1:");
            Member person1 = new Member("moein", "kazemi", 09331621112, 106, 1.9, false);
            person1VIP = person1.VIPMember();
            Console.WriteLine($"{person1.name},{person1.lastname}, disease : {person1.disease},{person1.height},{person1.phoneNum},{person1.weight},{person1.ID}, VIP : {person1VIP}");
            Member.BMIResult(person1);
            Console.WriteLine("------------------------------");
            Member person2 = new Member();
            person2VIP = person2.VIPMember();
            person2.name = "matin";
            person2.lastname = "kazemi";
            person2.disease = false;
            person2.height = 1.8;
            person2.phoneNum = 09331931112;
            person2.weight = 80;
            Console.WriteLine("person2:");
            Console.WriteLine($"{person2.name},{person2.lastname}, disease : {person2.disease},{person2.height},{person2.phoneNum},{person2.weight},{person2.ID}, VIP : {person2VIP}");
            Member.BMIResult(person2);
            Console.WriteLine("------------------------------");
            FitnessClub club1 = new FitnessClub("bashghahe javan", 6);
            club1.clubAddress = "tehran";
            club1.clubPopulation = 100;
            club1.AddMember(person1, person2);
            Console.WriteLine($"{club1.clubName}, population : {club1.clubPopulation}, upcoming day : {club1.upcoming},{club1.clubAddress}");
            Console.WriteLine("------------------------------");
            FitnessClub club2 = new FitnessClub("bashghahe tan_ara", "yazd",1,person2);
            club2.upcoming = 0;
            club2.AddMember(person1);
            Console.WriteLine($"{club2.clubName},  population : {club2.clubPopulation}, upcoming day : {club2.upcoming},{club2.clubAddress},{club2.member[0].name},{club2.member[1].name}");
            //Console.WriteLine("");
        }
    }
}
