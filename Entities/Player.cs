using System;

namespace SudokuSolver.Entities
{
    class Player
    {
        public int[] Position { get; private set; }
        public string Number { get; private set; }
        public Player()
        {
            Number = "0";
            Position = new int[2];
            Position[0] = 0;
            Position[1] = 0;
        }

        public bool Action(ConsoleKey key)
        {
            if (key == ConsoleKey.Escape)
            {
                Console.WriteLine("_Tem certeza que deseja sair(S/N)?");
                ConsoleKey anwser = Console.ReadKey().Key;
                if (anwser == ConsoleKey.S)
                {
                    Environment.Exit(0);
                }
                return false;
            }
            else if (key == ConsoleKey.UpArrow)
            {
                if (Position[0] == 0)
                {
                    Position[0] = 10;
                }
                else if (Position[0] == 4 | Position[0] == 8)
                {
                    Position[0] = Position[0] - 2;
                }
                else
                {
                    Position[0]--;
                }
                return false;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                if (Position[0] == 10)
                {
                    Position[0] = 0;
                }
                else if (Position[0] == 2 | Position[0] == 6)
                {
                    Position[0] = Position[0] + 2;
                }
                else
                {
                    Position[0]++;
                }
                return false;
            }
            else if (key == ConsoleKey.RightArrow)
            {
                if (Position[1] == 10)
                {
                    Position[1] = 0;
                }
                else if (Position[1] == 2 | Position[1] == 6)
                {
                    Position[1] = Position[1] + 2;
                }
                else
                {
                    Position[1]++;
                }
                return false;
            }
            else if (key == ConsoleKey.LeftArrow)
            {
                if (Position[1] == 0)
                {
                    Position[1] = 10;
                }
                else if (Position[1] == 4 | Position[1] == 8)
                {
                    Position[1] = Position[1] - 2;
                }
                else
                {
                    Position[1]--;
                }
                return false;
            }
            else if (key == ConsoleKey.NumPad1)
            {
                Number = "1";
                return true;
            }
            else if (key == ConsoleKey.NumPad2)
            {
                Number = "2";
                return true;
            }
            else if (key == ConsoleKey.NumPad3)
            {
                Number = "3";
                return true;
            }
            else if (key == ConsoleKey.NumPad4)
            {
                Number = "4";
                return true;
            }
            else if (key == ConsoleKey.NumPad5)
            {
                Number = "5";
                return true;
            }
            else if (key == ConsoleKey.NumPad6)
            {
                Number = "6";
                return true;
            }
            else if (key == ConsoleKey.NumPad7)
            {
                Number = "7";
                return true;
            }
            else if (key == ConsoleKey.NumPad8)
            {
                Number = "8";
                return true;
            }
            else if (key == ConsoleKey.NumPad9)
            {
                Number = "9";
                return true;
            }
            else if (key == ConsoleKey.D1)
            {
                Number = "1";
                return true;
            }
            else if (key == ConsoleKey.D2)
            {
                Number = "2";
                return true;
            }
            else if (key == ConsoleKey.D3)
            {
                Number = "3";
                return true;
            }
            else if (key == ConsoleKey.D4)
            {
                Number = "4";
                return true;
            }
            else if (key == ConsoleKey.D5)
            {
                Number = "5";
                return true;
            }
            else if (key == ConsoleKey.D6)
            {
                Number = "6";
                return true;
            }
            else if (key == ConsoleKey.D7)
            {
                Number = "7";
                return true;
            }
            else if (key == ConsoleKey.D8)
            {
                Number = "8";
                return true;
            }
            else if (key == ConsoleKey.D9)
            {
                Number = "9";
                return true;
            }else if (key == ConsoleKey.Multiply)
            {
                Number = "*";
                return true;
            }
            else if (key == ConsoleKey.Backspace)
            {
                Number = "*";
                return true;
            }
            else { 
                return false;
            }
        }
    }
}