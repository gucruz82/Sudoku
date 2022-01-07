using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver.Entities
{
    class Cell
    {
        public string Number { get; set; }
        public string Position { get; set; }

        public Cell(string number)
        {
            Number = number;
        }

        public Cell(string row, string column, string number)
        {
            Position = row + "," + column;
            Number = number;
        }
    }
}
