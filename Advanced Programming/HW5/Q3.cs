using System;
using System.Collections.Generic;

namespace Sudoku
{
    class Program
    {
        public static List<int> block1 = new List<int> { 5, 3, 6, 9, 8 };
        public static List<int> block2 = new List<int> { 7, 1, 9, 5 };
        public static List<int> block3 = new List<int> { 6 };
        public static List<int> block4 = new List<int> { 8, 4, 7 };
        public static List<int> block5 = new List<int> { 6, 8, 2, 3 };
        public static List<int> block6 = new List<int> { 3, 1, 6 };
        public static List<int> block7 = new List<int> { 6 };
        public static List<int> block8 = new List<int> { 4, 1, 9, 8 };
        public static List<int> block9 = new List<int> { 2, 8, 5, 9, 7 };
        public static List<List<int>> arrOFarr = new List<List<int>> { block1, block2, block3, block4, block5, block6, block7, block8, block9 };
        public static int[,] board = new int[9, 9]
        {
        { 5, 3, 0, 0, 7, 0, 0, 0, 0 },
        { 6, 0, 0, 1, 9, 5, 0, 0, 0 },
        { 0, 9, 8, 0, 0, 0, 0, 6, 0 },
        { 8, 0, 0, 0, 6, 0, 0, 0, 3 },
        { 4, 0, 0, 8, 0, 3, 0, 0, 1 },
        { 7, 0, 0, 0, 2, 0, 0, 0, 6 },
        { 0, 6, 0, 0, 0, 0, 2, 8, 0 },
        { 0, 0, 0, 4, 1, 9, 0, 0, 5 },
        { 0, 0, 0, 0, 8, 0, 0, 7, 9 }
        };
        public static bool block(int col , int row , int element)
        {
            bool boolean = true;
            if((row == 1 || row == 2 || row == 3) && (col == 1 || col == 2 || col == 3))
            {
                foreach(int i in block1)
                {
                    if (i != element)
                        boolean = true;
                    else
                        boolean = false;
                }
            }
            if ((row == 1 || row == 2 || row == 3) && (col == 4 || col == 5 || col == 6))
            {
                foreach (int i in block2)
                {
                    if (i != element)
                        boolean = true;
                    else
                        boolean = false;
                }
            }
            if ((row == 1 || row == 2 || row == 3) && (col == 7 || col == 8 || col == 9))
            {
                foreach (int i in block3)
                {
                    if (i != element)
                        boolean = true;
                    else
                        boolean = false;
                }
            }
            if ((row == 4 || row == 5 || row == 6) && (col == 1 || col == 2 || col == 3))
            {
                foreach (int i in block4)
                {
                    if (i != element)
                        boolean = true;
                    else
                        boolean = false;
                }
            }
            if ((row == 4 || row == 5 || row == 6) && (col == 4 || col == 5 || col == 6))
            {
                foreach (int i in block5)
                {
                    if (i != element)
                        boolean = true;
                    else
                        boolean = false;
                }
            }
            if ((row == 4 || row == 5 || row == 6) && (col == 7 || col == 8 || col == 9))
            {
                foreach (int i in block6)
                {
                    if (i != element)
                        boolean = true;
                    else
                        boolean = false;
                }
            }
            if ((row == 7 || row == 8 || row == 9) && (col == 1 || col == 2 || col == 3))
            {
                foreach (int i in block7)
                {
                    if (i != element)
                        boolean = true;
                    else
                        boolean = false;
                }
            }
            if ((row == 7 || row == 8 || row == 9) && (col == 4 || col == 5 || col == 6))
            {
                foreach (int i in block8)
                {
                    if (i != element)
                        boolean = true;
                    else
                        boolean = false;
                }
            }
            if ((row == 7 || row == 8 || row == 9) && (col == 7 || col == 8 || col == 9))
            {
                foreach (int i in block9)
                {
                    if (i != element)
                        boolean = true;
                    else
                        boolean = false;
                }
            }
            return boolean;
        }
        public static void addTOblock(int col, int row, int element)
        {
            if ((row == 1 || row == 2 || row == 3) && (col == 1 || col == 2 || col == 3))
            {
                block1.Add(element);
            }
            if ((row == 1 || row == 2 || row == 3) && (col == 4 || col == 5 || col == 6))
            {
                block2.Add(element);
            }
            if ((row == 1 || row == 2 || row == 3) && (col == 7 || col == 8 || col == 9))
            {
                block3.Add(element);
            }
            if ((row == 4 || row == 5 || row == 6) && (col == 1 || col == 2 || col == 3))
            {
                block4.Add(element);
            }
            if ((row == 4 || row == 5 || row == 6) && (col == 4 || col == 5 || col == 6))
            {
                block5.Add(element);
            }
            if ((row == 4 || row == 5 || row == 6) && (col == 7 || col == 8 || col == 9))
            {
                block6.Add(element);
            }
            if ((row == 7 || row == 8 || row == 9) && (col == 1 || col == 2 || col == 3))
            {
                block7.Add(element);
            }
            if ((row == 7 || row == 8 || row == 9) && (col == 4 || col == 5 || col == 6))
            {
                block8.Add(element);
            }
            if ((row == 7 || row == 8 || row == 9) && (col == 7 || col == 8 || col == 9))
            {
                block9.Add(element);
            }
        }
        public static void removFROMblock(int col, int row, int element)
        {
            if ((row == 1 || row == 2 || row == 3) && (col == 1 || col == 2 || col == 3))
            {
                block1.Remove(element);
            }
            if ((row == 1 || row == 2 || row == 3) && (col == 4 || col == 5 || col == 6))
            {
                block2.Remove(element);
            }
            if ((row == 1 || row == 2 || row == 3) && (col == 7 || col == 8 || col == 9))
            {
                block3.Remove(element);
            }
            if ((row == 4 || row == 5 || row == 6) && (col == 1 || col == 2 || col == 3))
            {
                block4.Remove(element);
            }
            if ((row == 4 || row == 5 || row == 6) && (col == 4 || col == 5 || col == 6))
            {
                block5.Remove(element);
            }
            if ((row == 4 || row == 5 || row == 6) && (col == 7 || col == 8 || col == 9))
            {
                block6.Remove(element);
            }
            if ((row == 7 || row == 8 || row == 9) && (col == 1 || col == 2 || col == 3))
            {
                block7.Remove(element);
            }
            if ((row == 7 || row == 8 || row == 9) && (col == 4 || col == 5 || col == 6))
            {
                block8.Remove(element);
            }
            if ((row == 7 || row == 8 || row == 9) && (col == 7 || col == 8 || col == 9))
            {
                block9.Remove(element);
            }
        }
        public static void ADD(int row , int column , int element)
        {
            bool checking = true;
            do
            {
                if ((row == 1 && column == 1) || (row == 1 && column == 2) || (row == 1 && column == 5) || (row == 2 && column == 1) || (row == 2 && column == 4) || (row == 2 && column == 5) || (row == 2 && column == 6) || (row == 3 && column == 2) || (row == 3 && column == 3) || (row == 3 && column == 8) || (row == 4 && column == 1) || (row == 4 && column == 5) || (row == 4 && column == 9) || (row == 5 && column == 1) || (row == 5 && column == 4) || (row == 5 && column == 6) || (row == 5 && column == 9) || (row == 6 && column == 1) || (row == 6 && column == 5) || (row == 6 && column == 9) || (row == 7 && column == 2) || (row == 7 && column == 7) || (row == 7 && column == 8) || (row == 8 && column == 4) || (row == 8 && column == 5) || (row == 8 && column == 6) || (row == 8 && column == 9) || (row == 9 && column == 5) || (row == 9 && column == 8) || (row == 9 && column == 9))
                {
                    checking = false;
                    Console.WriteLine("you cannot add to this part");
                    Console.WriteLine("enter another row");
                    row = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter another column");
                    column = int.Parse(Console.ReadLine());
                }
                else
                {
                    checking = true;
                }

            } while (checking == false);
            bool boolean = true;
            do
            {
                if (block(column, row, element))
                {
                    int i,j;
                    for (i = 0; i < 9; i++)
                    {
                        if (element != board[row - 1, i])
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("this number exist in this row");
                            Console.WriteLine("RR : enter the row");
                            row = int.Parse(Console.ReadLine());
                            Console.WriteLine("RR : enter the column");
                            column = int.Parse(Console.ReadLine());
                            Console.WriteLine("RR : enter the number");
                            element = int.Parse(Console.ReadLine());
                            i = 0;
                            boolean = false;
                        }
                    }
                    for (j = 0; j < 9; j++)
                    {
                        if (element != board[j, column - 1])
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("this number exist in this column");
                            Console.WriteLine("CR : enter the row");
                            row = int.Parse(Console.ReadLine());
                            Console.WriteLine("CR : enter the column");
                            column = int.Parse(Console.ReadLine());
                            Console.WriteLine("CR : enter the number");
                            element = int.Parse(Console.ReadLine());
                            j = 0;
                            boolean = false;
                        }
                    }
                    boolean = true;
                    board[row - 1, column - 1] = element;
                    addTOblock(column, row, element);
                }
                else
                {
                    Console.WriteLine("this number exist in this block");
                    Console.WriteLine("BR : enter the row");
                    row = int.Parse(Console.ReadLine());
                    Console.WriteLine("BR : enter the column");
                    column = int.Parse(Console.ReadLine());
                    Console.WriteLine("BR : enter the number");
                    element = int.Parse(Console.ReadLine());
                    boolean = false;
                }
            } while (boolean == false);
        }
        public static void DELETE(int row, int column, int element)
        {
            bool checking = true;
            do
            {
                if ((row == 1 && column == 1) || (row == 1 && column == 2) || (row == 1 && column == 5) || (row == 2 && column == 1) || (row == 2 && column == 4) || (row == 2 && column == 5) || (row == 2 && column == 6) || (row == 3 && column == 2) || (row == 3 && column == 3) || (row == 3 && column == 8) || (row == 4 && column == 1) || (row == 4 && column == 5) || (row == 4 && column == 9) || (row == 5 && column == 1) || (row == 5 && column == 4) || (row == 5 && column == 6) || (row == 5 && column == 9) || (row == 6 && column == 1) || (row == 6 && column == 5) || (row == 6 && column == 9) || (row == 7 && column == 2) || (row == 7 && column == 7) || (row == 7 && column == 8) || (row == 8 && column == 4) || (row == 8 && column == 5) || (row == 8 && column == 6) || (row == 8 && column == 9) || (row == 9 && column == 5) || (row == 9 && column == 8) || (row == 9 && column == 9))
                {
                    checking = false;
                    Console.WriteLine("you cannot delete this part");
                    Console.WriteLine("enter another row");
                    row = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter another column");
                    column = int.Parse(Console.ReadLine());
                }
                else
                {
                    checking = true;
                }

            } while (checking == false);
            board[row - 1, column - 1] = 0;
            removFROMblock(row, column, element);
        }
        public static void ShowChart()
        {
            for (int i = 0; i < 9; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < 9; j++)
                {
                    Console.Write($"{board[i, j]}" + "  ");
                }
            }
            Console.Write("\n");
        }
        public static void menu()
        {
            int ROW;
            int COL;
            int NUM;
            bool boolean = true;
            while (boolean)
            {
                Console.WriteLine("choose --ADD-- or --DELETE-- or --EXITE-- or --SHOW--");
                string input = Console.ReadLine();
                if (input.ToLower() == "add")
                {
                    do
                    {
                        Console.WriteLine("enter the row");
                        ROW = int.Parse(Console.ReadLine());
                        if ((ROW > 9 || ROW < 1))
                            Console.WriteLine("RR : incorect input");
                        Console.WriteLine("enter the column");
                        COL = int.Parse(Console.ReadLine());
                        if ((COL > 9 || COL < 1))
                            Console.WriteLine("CR : incorect input");
                        Console.WriteLine("enter the number to insert");
                        NUM = int.Parse(Console.ReadLine());
                        if ((NUM > 9 || NUM < 1))
                            Console.WriteLine("NR : incorect input");
                    } while ((ROW > 9 || ROW < 1) || (COL > 9 || COL < 1) || (NUM > 9 || NUM < 0));
                    ADD(ROW, COL, NUM);
                }
                if (input.ToLower() == "delete")
                {
                    do
                    {
                        Console.WriteLine("enter the row");
                        ROW = int.Parse(Console.ReadLine());
                        if ((ROW > 9 || ROW < 1))
                            Console.WriteLine("RR : incorect input");
                        Console.WriteLine("enter the column");
                        COL = int.Parse(Console.ReadLine());
                        if ((COL > 9 || COL < 1))
                            Console.WriteLine("CR : incorect input");
                        Console.WriteLine("enter the number to insert");
                        NUM = int.Parse(Console.ReadLine());
                        if ((NUM > 9 || NUM < 1))
                            Console.WriteLine("NR : incorect input");
                    } while ((ROW > 9 || ROW < 1) || (COL > 9 || COL < 1) || (NUM > 9 || NUM < 0));
                    DELETE(ROW, COL, NUM);
                }
                if (input.ToLower() == "show")
                    ShowChart();
                if (input.ToLower() == "exite")
                {
                    boolean = false;
                }
                if (input.ToLower() != "add" && input.ToLower() != "delete" && input.ToLower() != "exite" && input.ToLower() != "show")
                {
                    Console.WriteLine("incorect input");
                    menu();
                }
            }
        }
        static void Main(string[] args)
        {
            menu();
        }
    }
}
