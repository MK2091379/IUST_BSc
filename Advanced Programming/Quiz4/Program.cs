using System;
using System.Collections.Generic;

namespace Quiz3
{
    interface IEducated
    {
        public string Name 
        {
            get;
            set;
        }
        public string TopDegree
        {
            get;
            set;
        }
        public string imgUrl
        {
            get;
            set;
        }
    }
    interface ITeacher:IEducated
    {
        string Teach();
    }
    interface INurse : IEducated
    {
        string Play(Khalle K);
    }
    public class Citizen
    {
        public enum Degree { PhD, Master, Bachelor, Diploma };
        private string name;
        private string nationalled;
        private bool Crime;
        public Citizen(string name , string nationalled,bool crime)
        {
            this.name = name;
            this.nationalled = nationalled;
            this.Crime = crime;
        }
        public bool CRIME
        {
            get
            {
                return this.Crime;
            }
            set
            {
                this.Crime = value;
            }
        }
        public string Nationalld
        {
            get
            {
                return this.nationalled;
            }
            set
            {
                this.nationalled = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public virtual void influnce()
        {
            Console.WriteLine("influence all");
        }
    }
    public class Khalle:Citizen,INurse
    {
        private string url;
        private string degree;
        
        public Khalle(string name, string nationalled , string degree , string url,bool crime) : base(name, nationalled,crime)
        {
            this.url = url;
            this.degree = degree;
        }
        public string Play(Khalle K)
        {
            return $"khalle {K.Name} is playing";
        }
        public string TopDegree
        {
            get
            {
                return this.degree;
            }
            set
            {
                this.degree = value;
            }
        }
        public string imgUrl
        {
            get
            {
                return this.url;
            }
            set
            {
                this.url = value;
            }
        }
        public override void influnce()
        {
            Console.WriteLine("influence khalle");
        }
    }
    public class Dabir :Citizen ,ITeacher
    {
        private string url;
        private string degree;
        private string ClassName;
        public Dabir(string name, string nationalled, string degree, string url,string classname,bool crime) : base(name, nationalled,crime)
        {
            this.url = url;
            this.degree = degree;
            this.ClassName = classname;
        }
        public string TopDegree
        {
            get
            {
                return this.degree;
            }
            set
            {
                this.degree = value;
            }
        }
        public string imgUrl
        {
            get
            {
                return this.url;
            }
            set
            {
                this.url = value;
            }
        }
        public string Teach()
        {
            return $"{this.ClassName} : {this.Name} is teaching";
        }
        public override void influnce()
        {
            Console.WriteLine("influence dabir");
        }
    }
    public class Professor : Citizen,ITeacher
    {
        private string url;
        private string degree;
        private string ClassName;
        private int researchCount;
        public Professor(string name, string nationalled, string degree, string url,string classname, int researchcount,bool crime) : base(name, nationalled,crime)
        {
            this.url = url;
            this.degree = degree;
            this.ClassName = classname;
            this.researchCount = researchcount;
        }
        public int ResearchCount
        {
            get
            {
                return this.researchCount;
            }
            set
            {
                this.researchCount = value;
            }
        }
        public string TopDegree
        {
            get
            {
                return this.degree;
            }
            set
            {
                this.degree = value;
            }
        }
        public string imgUrl
        {
            get
            {
                return this.url;
            }
            set
            {
                this.url = value;
            }
        }
        public string Teach()
        {
            return $"{this.ClassName} : {this.Name} is mentoring";
        }
        public override void influnce()
        {
            Console.WriteLine("influence professor");
        }
    }
    public class PoliceSite
    {
        private List<string> blackMan = new List<string>();
        public List<string> BlackList
        {
            get
            {
                return this.blackMan;
            }
            set
            {
                BlackList = new List<string>();
                this.blackMan = value;
            }
        }
        public void BackgroundCheck(Citizen C)
        {
            if (C.CRIME)
                blackMan.Add(C.Name);
        }
    }
    public class EduInstitute
    {
        public List<string> INIS = new List<string>();
        private string Name;
        private string Minimumdegree;
        private string[] arr;
        public EduInstitute(string name,string minimumdegree,params string[] teachers)
        {
            this.Name = name;
            this.Minimumdegree = minimumdegree;
            arr = new string[teachers.Length];
            this.arr = teachers;
        }
        public string Title
        {
            get
            {
                return this.Name;
            }
            set
            {
                this.Name = value;
            }
        }
        public string MinimunDegree
        {
            get
            {
                return Minimumdegree;
            }
            set
            {
                this.Minimumdegree = value;
            }
        }
        public string[] Teachers
        {
            get
            {
                return this.arr;
            }
            set
            {
                this.arr = value;
            }
        }
        public bool IsEligible(EduInstitute E)
        {
            if (E.Minimumdegree == "diploma" || E.Minimumdegree == "master" || E.Minimumdegree == "phd" || E.Minimumdegree == "bechelor")
                return true;
            else
                return false;
        }
        public void Register(EduInstitute E)
        {
            if (IsEligible(E))
                INIS.Add(E.Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool boolean = true;
            List<Citizen> listCiti = new List<Citizen>();
            List<EduInstitute> listInis = new List<EduInstitute>();
            List<int> ID = new List<int>();
            while (boolean)
            {
                Console.WriteLine("enter input");
                string input = Console.ReadLine();
                if (input == "exite")
                    boolean = false;
                if(input == "log")
                {
                    for(int i = 0; i < listCiti.Count; i++)
                    {
                        Console.WriteLine();
                    }
                }
                if (input == "citizen")
                {
                    Console.WriteLine("enter crime");
                    bool crime = bool.Parse(Console.ReadLine());
                    Console.WriteLine("enter name");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter nationalled");
                    string nationalled = Console.ReadLine();
                    foreach (var member in listCiti)
                    {
                        if (member.Name != name && member.Nationalld != nationalled)
                        {
                            Citizen C = new Citizen(name, nationalled, crime);
                            listCiti.Add(C);
                        }
                        else
                            Console.WriteLine("exist");
                    }
                }
                if (input == "id")
                {
                    Console.WriteLine("enter id");
                    int id = int.Parse(Console.ReadLine());
                    foreach (var member in ID)
                    {
                        if (member != id)
                        {
                            ID.Add(id);
                        }
                        else
                            Console.WriteLine("exist");
                    }
                }
                if (input == "enter learning center")
                {
                    Console.WriteLine("enter name");
                    string INISname = Console.ReadLine();
                    Console.WriteLine("enter nationalled");
                    string teacherName = Console.ReadLine();
                    Console.WriteLine("enter minimum degree");
                    string minimumdegree = Console.ReadLine();
                    foreach (var member in listInis)
                    {
                        if (member.Title != INISname)
                        {
                            EduInstitute E = new EduInstitute(INISname, minimumdegree, teacherName);
                            listInis.Add(E);
                        }
                        else
                            Console.WriteLine("exist");
                    }
                }
            }
        }
    }
}
