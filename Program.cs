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
            string[] games = System.IO.File.ReadAllLines(@"C:\Users\gucru\source\repos\SudokuSolver\Sudoku1\Sudoku1.txt");
            Random rnd1 = new Random();
            string numbers = games[rnd1.Next(games.Length)];
            Grid grid = new Grid(numbers.ToString());
            grid.Fill();
            while (true)
            {
                Console.Clear();
                int count = 0;
                for (int i = 0; i < 11; i++)
                {
                    Console.WriteLine();
                    for (int k = 0; k < 11; k++)
                    {
                        Console.Write(grid.Box[count].Number + " ");
                        count++;
                    }
                }
                Console.WriteLine();
                Console.WriteLine(grid.Row());
                Console.WriteLine(grid.Column());
                Console.WriteLine(grid._Box());
                Console.WriteLine(grid.Full());
                Console.WriteLine(grid.Verification());
                Console.WriteLine();
                Console.Write("Digite a célula para Inserir um número(L/C):");
                string[] position = Console.ReadLine().Split(",");
                int row = int.Parse(position[0]);
                int column = int.Parse(position[1]);

                foreach (Cell cell in grid.Box)
                {
                    if (cell.Position == $"{row},{column}")
                    {
                        if (cell.Fixed == true)
                        {
                            Console.WriteLine("O número desta posição não pode ser editado!");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.Write("Número:");
                            cell.Number = Console.ReadLine();
                        }
                    }
                }
            }
        }
    }
}