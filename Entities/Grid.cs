using SudokuSolver.Entities;
using System.Collections.Generic;
namespace SudokuSolver.Entities
{
    class Grid
    {
        public List<Cell> Box { get; set; }
        public string Pattern { get; set; }

        public Grid(string pattern)
        {
            Pattern = pattern;
            Box = new List<Cell>();
        }
        public void fill()
        {
            int count = 0;
            int row;
            int column;
            for (int i = 0; i < 11; i++)
            {
                for (int k = 0; k < 11; k++)
                {
                    row = i;
                    column = k;
                    if (i == 3 | i == 7)
                    {
                        Box.Add(new Cell("x","x","-"));
                        
                    }else if (k == 3 | k == 7)
                    {
                        Box.Add(new Cell("y", "y", "|"));

                    }else
                    {
                        if (column <= 3 & row <= 3)
                        {
                            row++;
                            column++;
                        }
                        else if (column > 3 & column < 7 & row <= 3)
                        {
                            row++;
                        }
                        else if (column >= 7 & row <= 3)
                        {
                            row++;
                            column--;
                        }
                        else if (column <= 3 & row > 3 & row < 7)
                        {
                            column++;
                        }
                        else if (column >= 7 & row > 3 & row < 7)
                        {
                            column--;
                        }
                        else if (column <= 3 & row >= 7)
                        {
                            column++;
                            row--;
                        }
                        else if (column > 3 & column < 7 & row >= 7)
                        {
                            row--;
                        }
                        else if (column >= 7 & row >= 7)
                        {
                            column--;
                            row--;
                        }
                        Box.Add(new Cell($"{row}", $"{column}", "1"));
                        count++;
                    }
                }
            }
        }

    }
}
