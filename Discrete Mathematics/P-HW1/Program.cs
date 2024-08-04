using System;
using System.Collections.Generic;

namespace MyChart
{
    class Program
    {
        static void Main()
        {
            static int maximum(List<int> list)
            {
                int max = list[0];
                for (int i = 0; i < list.Count; i++)
                {
                    if (max - list[i] < 0)
                        max = list[i];
                }
                return max;
            }
            static int minimum(List<int> list)
            {
                int min = list[0];
                for (int i = 0; i < list.Count; i++)
                {
                    if (min - list[i] > 0)
                        min = list[i];
                }
                return min;
            }
            static void chart(string input)
            {
                char[] MyChar = new char[input.Length];
                int counter = 1;
                MyChar = input.ToCharArray();
                List<int> ClaculateHight = new List<int>();
                foreach (char i in MyChar)
                {
                    if (i == 'R')
                    {
                        ClaculateHight.Add(counter);
                        counter++;
                    }
                    else if (i == 'F')
                    {
                        counter--;
                        ClaculateHight.Add(counter);
                    }
                    else if (i == 'C')
                    {
                        ClaculateHight.Add(counter);
                    }
                }
                foreach (int i in ClaculateHight)
                {
                    if (i < 1)
                    {
                        int m = -(minimum(ClaculateHight) - 1);
                        for (int j = 0; j < ClaculateHight.Count; j++)
                        {
                            ClaculateHight[j] += m;
                        }
                    }
                }
                int ColumnHight = maximum(ClaculateHight);
                List<char> MyList = new List<char>();
                foreach (char i in MyChar)
                {
                    if (i == 'R')
                        MyList.Add('/');
                    if (i == 'F')
                        MyList.Add('\\');
                    if (i == 'C')
                        MyList.Add('_');
                }
                while (ColumnHight > 0)
                {
                    List<char> FinishResult = new List<char>();
                    for (int i = 0; i < input.Length + 3; i++)
                    {
                        if (i == 0)
                            FinishResult.Add('|');
                        else
                            FinishResult.Add(' ');
                    }
                    int max = maximum(ClaculateHight);
                    for (int i = 0; i < ClaculateHight.Count; i++)
                    {
                        if (ClaculateHight[i] == max)
                            FinishResult[i + 2] = MyList[i];
                    }
                    string FinshResultStr = "";
                    for (int i = 0; i < FinishResult.Count; i++)
                    {
                        FinshResultStr += FinishResult[i];
                    }
                    Console.Write(FinshResultStr + "\n");
                    for (int i = 0; i < ClaculateHight.Count; i++)
                    {
                        if (ClaculateHight[i] == max)
                            ClaculateHight[i] = 0;
                    }
                    ColumnHight -= 1;
                }
                Console.Write("+");
                for (int i = 0; i < input.Length + 2; i++)
                    Console.Write("-");
            }
            string input = Console.ReadLine();
            chart(input);
        }
    }
}
