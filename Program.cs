using System;
using System.Collections.Generic;
using SudokuSolver.Entities;


namespace SudokuSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            bool movement = true;
            Player player = new Player();
            string[] games = System.IO.File.ReadAllLines(@"C:\Users\gucru\source\repos\SudokuSolver\Sudoku1\Sudoku1.txt");
            Random rnd1 = new Random();
            string numbers = games[rnd1.Next(games.Length)];
            Grid grid = new Grid(numbers.ToString());
            grid.Fill();
            while (grid.Verification() == true)
            {
                string currentRow = "";
                string currentColumn = "";
                string currentBox = "";
                Console.Clear();
                int count = 0;
                for (int i = 0; i < 11; i++)
                {
                    Console.WriteLine();
                    for (int k = 0; k < 11; k++)
                    {
                        if (player.Position[0] == i & player.Position[1] == k)
                        {
                            currentRow = grid.Box[count].Position[0].ToString();
                            currentColumn = grid.Box[count].Position[2].ToString();
                            currentBox = grid.Box[count].BoxNumber.ToString();
                            if (movement == false)
                            {
                                if (grid.Box[count].Fixed == true)
                                {   
                                }
                                else
                                {
                                    grid.Box[count].Number = player.Number;
                                }
                            }
                            movement = true;
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Write(grid.Box[count].Number + " ");
                            Console.BackgroundColor = ConsoleColor.Black;
                            count++;
                        }
                        else
                        {
                            if (grid.Box[count].Fixed == true)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write(grid.Box[count].Number + " ");
                                Console.ForegroundColor = ConsoleColor.White;
                                count++;
                            }
                            else
                            {
                                Console.Write(grid.Box[count].Number + " ");
                                count++;
                            }
                        }
                    }
                }
                if (grid.Row(int.Parse(currentRow)) == false)
                {
                    Console.WriteLine();
                    Console.WriteLine($"A linha {currentRow} possui mais de um número {player.Number}!!");
                }
                if (grid.Column(int.Parse(currentColumn)) == false)
                {
                    Console.WriteLine();
                    Console.WriteLine($"A Coluna {currentColumn} possui mais de um número {player.Number}!!");
                }
                if (grid._Box(int.Parse(currentBox)) == false)
                {
                    Console.WriteLine();
                    Console.WriteLine($"A Caixa {currentBox} possui mais de um número {player.Number}!!");
                }
                ConsoleKey pressedKey = Console.ReadKey().Key;
                if (player.Action(pressedKey) == true)
                {
                    movement = false;
                }
            }
        }
    }
}