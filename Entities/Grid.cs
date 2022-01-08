using System;
using System.Collections.Generic;
namespace SudokuSolver.Entities
{
    class Grid
    {
        public List<Cell> Box { get; private set; }
        public string Pattern { get; private set; }

        public Grid(string pattern)
        {
            Pattern = pattern;
            Box = new List<Cell>();
        }
        public bool Row(int row)
        {
            string row_numbers = "";
            foreach (Cell cell in Box)
            {
                if (cell.Position[0].ToString() == $"{row}")
                {
                    if (row_numbers.Contains(cell.Number) & cell.Number != "*"
                    & cell.Number != "|" & cell.Number != "-")
                    {
                        return false;
                    }
                    else
                    {
                        row_numbers = row_numbers + cell.Number;
                    }
                }
            }
                return true;
        }
        public bool Column(int column)
        {
            string column_numbers = "";
            foreach (Cell cell in Box)
            {
                if (cell.Position[2].ToString() == $"{column}")
                {
                    if (column_numbers.Contains(cell.Number) & cell.Number != "*"
                    & cell.Number != "|" & cell.Number != "-")
                    {
                        return false;
                    }
                    else
                    {
                        column_numbers = column_numbers + cell.Number;
                    }
                }
            }
            return true;
        }
        public bool _Box(int box)
        {
            string box_numbers = "";
            foreach (Cell cell in Box)
            {
                if (box == 1)
                {
                    for (int i = 1; i <= 3; i++)
                    {
                        for (int k = 1; k <= 3; k++)
                        {
                            if (cell.Position[0].ToString() == $"{i}" &
                                cell.Position[2].ToString() == $"{k}" &
                                cell.Number != "*")
                            {
                                if (box_numbers.Contains(cell.Number))
                                {
                                    return false;
                                }
                                else
                                {
                                    box_numbers = box_numbers + cell.Number;
                                }
                            }
                        }
                    }
                }else if (box == 2)
                {
                    for (int i = 1; i <= 3; i++)
                    {
                        for (int k = 4; k <= 6; k++)
                        {
                            if (cell.Position[0].ToString() == $"{i}" &
                                cell.Position[2].ToString() == $"{k}" &
                                cell.Number != "*")
                            {
                                if (box_numbers.Contains(cell.Number))
                                {
                                    return false;
                                }
                                else
                                {
                                    box_numbers = box_numbers + cell.Number;
                                }
                            }
                        }
                    }
                }
                else if (box == 3)
                {
                    for (int i = 1; i <= 3; i++)
                    {
                        for (int k = 7; k <= 9; k++)
                        {
                            if (cell.Position[0].ToString() == $"{i}" &
                                cell.Position[2].ToString() == $"{k}" &
                                cell.Number != "*")
                            {
                                if (box_numbers.Contains(cell.Number))
                                {
                                    return false;
                                }
                                else
                                {
                                    box_numbers = box_numbers + cell.Number;
                                }
                            }
                        }
                    }
                }
                else if (box == 4)
                {
                    for (int i = 4; i <= 6; i++)
                    {
                        for (int k = 1; k <= 3; k++)
                        {
                            if (cell.Position[0].ToString() == $"{i}" &
                                cell.Position[2].ToString() == $"{k}" &
                                cell.Number != "*")
                            {
                                if (box_numbers.Contains(cell.Number))
                                {
                                    return false;
                                }
                                else
                                {
                                    box_numbers = box_numbers + cell.Number;
                                }
                            }
                        }
                    }
                }
                else if (box == 5)
                {
                    for (int i = 4; i <= 6; i++)
                    {
                        for (int k = 4; k <= 6; k++)
                        {
                            if (cell.Position[0].ToString() == $"{i}" &
                                cell.Position[2].ToString() == $"{k}" &
                                cell.Number != "*")
                            {
                                if (box_numbers.Contains(cell.Number))
                                {
                                    return false;
                                }
                                else
                                {
                                    box_numbers = box_numbers + cell.Number;
                                }
                            }
                        }
                    }
                }
                else if (box == 6)
                {
                    for (int i = 4; i <= 6; i++)
                    {
                        for (int k = 7; k <= 9; k++)
                        {
                            if (cell.Position[0].ToString() == $"{i}" &
                                cell.Position[2].ToString() == $"{k}" &
                                cell.Number != "*")
                            {
                                if (box_numbers.Contains(cell.Number))
                                {
                                    return false;
                                }
                                else
                                {
                                    box_numbers = box_numbers + cell.Number;
                                }
                            }
                        }
                    }
                }
                else if (box == 7)
                {
                    for (int i = 7; i <= 9; i++)
                    {
                        for (int k = 1; k <= 3; k++)
                        {
                            if (cell.Position[0].ToString() == $"{i}" &
                                cell.Position[2].ToString() == $"{k}" &
                                cell.Number != "*")
                            {
                                if (box_numbers.Contains(cell.Number))
                                {
                                    return false;
                                }
                                else
                                {
                                    box_numbers = box_numbers + cell.Number;
                                }
                            }
                        }
                    }
                }
                else if (box == 8)
                {
                    for (int i = 7; i <= 9; i++)
                    {
                        for (int k = 4; k <= 6; k++)
                        {
                            if (cell.Position[0].ToString() == $"{i}" &
                                cell.Position[2].ToString() == $"{k}" &
                                cell.Number != "*")
                            {
                                if (box_numbers.Contains(cell.Number))
                                {
                                    return false;
                                }
                                else
                                {
                                    box_numbers = box_numbers + cell.Number;
                                }
                            }
                        }
                    }
                }
                else if (box == 9)
                {
                    for (int i = 7; i <= 9; i++)
                    {
                        for (int k = 7; k <= 9; k++)
                        {
                            if (cell.Position[0].ToString() == $"{i}" &
                                cell.Position[2].ToString() == $"{k}" &
                                cell.Number != "*")
                            {
                                if (box_numbers.Contains(cell.Number))
                                {
                                    return false;
                                }
                                else
                                {
                                    box_numbers = box_numbers + cell.Number;
                                }
                            }
                        }
                    }
                }    
            }
            return true;
        }
        public void Fill()
        {
            int box = 0;
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
                        Box.Add(new Cell("x", "x", "-", false, 0));

                    }
                    else if (k == 3 | k == 7)
                    {
                        Box.Add(new Cell("y", "y", "|", false, 0));

                    }
                    else
                    {
                        if (column <= 3 & row <= 3)
                        {
                            box = 1;
                            row++;
                            column++;
                        }
                        else if (column > 3 & column < 7 & row <= 3)
                        {
                            box = 2;
                            row++;
                        }
                        else if (column >= 7 & row <= 3)
                        {
                            box = 3;
                            row++;
                            column--;
                        }
                        else if (column <= 3 & row > 3 & row < 7)
                        {
                            box = 4;
                            column++;
                        }
                        else if (column > 3 & column < 7 & row > 3 & row < 7)
                        {
                            box = 5;
                        }
                        else if (column >= 7 & row > 3 & row < 7)
                        {
                            box = 6;
                            column--;
                        }
                        else if (column <= 3 & row >= 7)
                        {
                            box = 7;
                            column++;
                            row--;
                        }
                        else if (column > 3 & column < 7 & row >= 7)
                        {
                            box = 8;
                            row--;
                        }
                        else if (column >= 7 & row >= 7)
                        {
                            box = 9;
                            column--;
                            row--;
                        }
                        if (Pattern[count].ToString() == "0")
                        {
                            Box.Add(new Cell($"{row}", $"{column}", "*", false, box));
                            count++;
                        }
                        else
                        {
                            Box.Add(new Cell($"{row}", $"{column}", $"{Pattern[count]}", true, box));
                            count++;
                        }

                    }
                }
            }
        }
        public bool Rows()
        {
            string row_numbers = "";
            for (int i = 1; i <= 9; i++)
            {
                row_numbers = "";
                foreach (Cell cell in Box)
                {
                    if (cell.Position[0].ToString() == $"{i}")
                    {
                        if (row_numbers.Contains(cell.Number) & cell.Number != "*"
                        & cell.Number != "|" & cell.Number != "-")
                        {
                            return false;
                        }
                        else
                        {
                            row_numbers = row_numbers + cell.Number;
                        }
                    }
                }
            }
            return true;
        }
        public bool Columns()
        {
            string column_numbers = "";
            for (int i = 1; i <= 9; i++)
            {
                column_numbers = "";
                foreach (Cell cell in Box)
                {
                    if (cell.Position[2].ToString() == $"{i}")
                    {
                        if (column_numbers.Contains(cell.Number) & cell.Number != "*"
                        & cell.Number != "|" & cell.Number != "-")
                        {
                            return false;
                        }
                        else
                        {
                            column_numbers = column_numbers + cell.Number;
                        }
                    }
                }
            }
            return true;
        }
        public bool _Boxes()
        {
            string box1_numbers = "";
            string box2_numbers = "";
            string box3_numbers = "";
            string box4_numbers = "";
            string box5_numbers = "";
            string box6_numbers = "";
            string box7_numbers = "";
            string box8_numbers = "";
            string box9_numbers = "";
            foreach (Cell cell in Box)
            {
                for (int i = 1; i <= 3; i++)
                {
                    for (int k = 1; k <= 3; k++)
                    {
                        if (cell.Position[0].ToString() == $"{i}" &
                            cell.Position[2].ToString() == $"{k}" &
                            cell.Number != "*")
                        {
                            if (box1_numbers.Contains(cell.Number))
                            {
                                return false;
                            }
                            else
                            {
                                box1_numbers = box1_numbers + cell.Number;
                            }
                        }
                    }
                }
                for (int i = 1; i <= 3; i++)
                {
                    for (int k = 4; k <= 6; k++)
                    {
                        if (cell.Position[0].ToString() == $"{i}" &
                            cell.Position[2].ToString() == $"{k}" &
                            cell.Number != "*")
                        {
                            if (box2_numbers.Contains(cell.Number))
                            {
                                return false;
                            }
                            else
                            {
                                box2_numbers = box2_numbers + cell.Number;
                            }
                        }
                    }
                }
                for (int i = 1; i <= 3; i++)
                {
                    for (int k = 7; k <= 9; k++)
                    {
                        if (cell.Position[0].ToString() == $"{i}" &
                            cell.Position[2].ToString() == $"{k}" &
                            cell.Number != "*")
                        {
                            if (box3_numbers.Contains(cell.Number))
                            {
                                return false;
                            }
                            else
                            {
                                box3_numbers = box3_numbers + cell.Number;
                            }
                        }
                    }
                }
                for (int i = 4; i <= 6; i++)
                {
                    for (int k = 1; k <= 3; k++)
                    {
                        if (cell.Position[0].ToString() == $"{i}" &
                            cell.Position[2].ToString() == $"{k}" &
                            cell.Number != "*")
                        {
                            if (box4_numbers.Contains(cell.Number))
                            {
                                return false;
                            }
                            else
                            {
                                box4_numbers = box4_numbers + cell.Number;
                            }
                        }
                    }
                }
                for (int i = 4; i <= 6; i++)
                {
                    for (int k = 4; k <= 6; k++)
                    {
                        if (cell.Position[0].ToString() == $"{i}" &
                            cell.Position[2].ToString() == $"{k}" &
                            cell.Number != "*")
                        {
                            if (box5_numbers.Contains(cell.Number))
                            {
                                return false;
                            }
                            else
                            {
                                box5_numbers = box5_numbers + cell.Number;
                            }
                        }
                    }
                }
                for (int i = 4; i <= 6; i++)
                {
                    for (int k = 7; k <= 9; k++)
                    {
                        if (cell.Position[0].ToString() == $"{i}" &
                            cell.Position[2].ToString() == $"{k}" &
                            cell.Number != "*")
                        {
                            if (box6_numbers.Contains(cell.Number))
                            {
                                return false;
                            }
                            else
                            {
                                box6_numbers = box6_numbers + cell.Number;
                            }
                        }
                    }
                }
                for (int i = 7; i <= 9; i++)
                {
                    for (int k = 1; k <= 3; k++)
                    {
                        if (cell.Position[0].ToString() == $"{i}" &
                            cell.Position[2].ToString() == $"{k}" &
                            cell.Number != "*")
                        {
                            if (box7_numbers.Contains(cell.Number))
                            {
                                return false;
                            }
                            else
                            {
                                box7_numbers = box7_numbers + cell.Number;
                            }
                        }
                    }
                }
                for (int i = 7; i <= 9; i++)
                {
                    for (int k = 4; k <= 6; k++)
                    {
                        if (cell.Position[0].ToString() == $"{i}" &
                            cell.Position[2].ToString() == $"{k}" &
                            cell.Number != "*")
                        {
                            if (box8_numbers.Contains(cell.Number))
                            {
                                return false;
                            }
                            else
                            {
                                box8_numbers = box8_numbers + cell.Number;
                            }
                        }
                    }
                }
                for (int i = 7; i <= 9; i++)
                {
                    for (int k = 7; k <= 9; k++)
                    {
                        if (cell.Position[0].ToString() == $"{i}" &
                            cell.Position[2].ToString() == $"{k}" &
                            cell.Number != "*")
                        {
                            if (box9_numbers.Contains(cell.Number))
                            {
                                return false;
                            }
                            else
                            {
                                box9_numbers = box9_numbers + cell.Number;
                            }
                        }
                    }
                }
            }
            return true;
        }
        public bool Full()
        {
            foreach (Cell cell in Box)
            {
                if (cell.Number == "*")
                {
                    return false;
                }
            }
            return true;
        }
        public bool Verification()
        {
            if (Rows() == true & Columns() == true & _Boxes() == true & Full() == true)
            {
                Console.Clear();
                Console.WriteLine("Parabéns, você terminou!!!");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}