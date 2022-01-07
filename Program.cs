using System;
using SudokuSolver.Entities;
using System.IO;
using System.Collections.Generic;

namespace SudokuSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = System.IO.File.ReadAllText(@"C:\Users\gucru\source\repos\SudokuSolver\Sudoku1\Sudoku1.txt");
            Grid grid = new Grid(numbers.ToString());
            Console.WriteLine(grid.Pattern);
            grid.fill();
            int count = 0;
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine();
                for (int k = 0; k < 11; k++)
                {
                    Console.Write(grid.Box[count].Position + " ");
                    count++;
                }
            }
            count = 0;
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine();
                for (int k = 0; k < 11; k++)
                {
                    Console.Write(grid.Box[count].Number + " ");
                    count++;
                }
            }
            /*
            string[,] board = new string[11, 11];
            count = 0;
            for (int i = 0; i < 11; i++)
            {
                for (int k = 0; k < 11; k++)
                {
                    if (i == 3 | i == 7)
                    {
                        board[i, k] = "-";
                    }
                    else if (k == 3 | k == 7)
                    {
                        board[i, k] = "|";
                    }
                    else
                    {
                        if (numbers[count].ToString() == "0")
                        {
                            board[i, k] = " ";
                            count++;
                        }
                        else
                        {
                            board[i, k] = numbers[count].ToString();
                            count++;
                        }
                    }
                }
            }
            
            while (true)
            {
                try
                {
                    Console.Clear();
                    for (int i = 0; i < 11; i++)
                    {
                        Console.WriteLine();
                        for (int k = 0; k < 11; k++)
                        {
                            Console.Write(board[i, k] + " ");
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Digite a célula para Inserir um número(L/C):");
                    string[] position = (Console.ReadLine().Split(","));
                    int row = int.Parse(position[0]);
                    int column = int.Parse(position[1]);
                    if (column <= 3 & row <= 3)
                    {
                        row--;
                        column--;
                    }
                    else if (column > 3 & column < 7 & row <= 3)
                    {
                        row--;
                    }
                    else if (column >= 7 & row <= 3)
                    {
                        row--;
                        column++;
                    }
                    else if (column <= 3 & row > 3 & row < 7)
                    {
                        column--;
                    }
                    else if (column >= 7 & row > 3 & row < 7)
                    {
                        column++;
                    }
                    else if (column <= 3 & row >= 7)
                    {
                        column--;
                        row++;
                    }
                    else if (column > 3 & column < 7 & row >= 7)
                    {
                        row++;
                    }
                    else if (column >= 7 & row >= 7)
                    {
                        column++;
                        row++;
                    }
                    Console.WriteLine("Número:");
                    board[row, column] = Console.ReadLine();
                }
                catch { }
            }*/

        }
    }
}