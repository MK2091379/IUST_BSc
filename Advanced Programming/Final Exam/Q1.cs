using System;
using System.Collections.Generic;

namespace FinalExam
{
    class Room 
    {
        int windows;
        int Windows { get { return this.windows; } set { this.windows = value; } }
        int doors;
        public int Doors { get { return this.doors; } set { this.doors = value; } }
        public Dictionary<int, string> roomDoors = new Dictionary<int, string>();
        public Room()
        {
            Room room = new Room(0, 0);
        }
        public Room(int windows , int doors)
        {
            if (windows < 0 || doors < 0)
                throw new Exception("the number of doors or windows cant be negative.");
            else
            {
                this.doors = doors;
                this.windows = windows;

                for (int i = 0; i < this.Doors; i++)
                {
                    this.roomDoors.Add(i, "close");
                }
            }
        }
        public void open(int i)
        {
            roomDoors[i] = "open";
        }
        public void close(int i)
        {
            roomDoors[i] = "close";
        }
        public bool IsAllClosed()
        {
            bool boolean = true;
            return boolean;
        }
    }
    static class ex 
    {
        public static void closeAll(this Room room)
        {
            for(int i = 0; i < room.Doors; i++)
            {
                room.roomDoors[i] = "close";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
             
        }
    }
}
