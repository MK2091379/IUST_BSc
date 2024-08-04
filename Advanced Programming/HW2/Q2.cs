using System;

namespace RotateMatrix
{
    class Program
    {
        static void RotateMatrix(int dimension,int rotateDegree)
        {
            int[,] mymatrix = new int[dimension, dimension];
            for (int lines = 0; lines < dimension; lines++)
            {
                Console.WriteLine("enter the line {0}", lines+1);
                for (int columns = 0; columns < dimension; columns++)
                {
                    mymatrix[lines, columns] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine("main matrix:");
            for (int lines = 0; lines < dimension; lines++)
            {
                Console.Write("\n");
                for (int columns = 0; columns < dimension; columns++)
                {
                    if (mymatrix[lines, columns] < 10)
                    {
                        Console.Write(mymatrix[lines, columns] + "  ");
                    }
                    else
                    {
                        Console.Write(mymatrix[lines, columns] + " ");
                    }
                }
                
            }
            Console.Write("\n");
            Console.WriteLine("--------------------------------");
            int[,] rotatedMatrix = new int[dimension, dimension];
            if (rotateDegree == 90)
            {
                for (int i = 0; i < dimension; i++)
                {
                    for (int j = 0; j < dimension; j++)
                    {
                        rotatedMatrix[i, j] = mymatrix[dimension - (j + 1), i];
                    }
                }
            }
            if (rotateDegree == 180)
            {
                for (int i = 0; i < dimension; i++)
                {
                    for (int j = 0; j < dimension; j++)
                    {
                        rotatedMatrix[i, j] = mymatrix[dimension - (i + 1), dimension - (j+1)];
                    }
                }
            }
            if (rotateDegree == 270)
            {
                for (int i = 0; i < dimension; i++)
                {
                    for (int j = 0; j < dimension; j++)
                    {
                        rotatedMatrix[i, j] = mymatrix[j,dimension - (i+1)];
                    }
                }
            }
            Console.WriteLine("rotated matrix:");
            for (int lines = 0; lines < dimension; lines++)
            {
                Console.Write("\n");
                for (int columns = 0; columns < dimension; columns++)
                {
                    if (rotatedMatrix[lines, columns] < 10)
                    {
                        Console.Write(rotatedMatrix[lines, columns] + "  ");
                    }
                    else
                    {
                        Console.Write(rotatedMatrix[lines, columns] + " ");
                    }
                }

            }
        }       
        static void Main(string[] args)
        {
            Console.WriteLine("enter the dimension of matrix : ");
            int input_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("enter the the rotate degree : ");
            int input_2 = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------");
            RotateMatrix(input_1,input_2);
        }
    }
}
