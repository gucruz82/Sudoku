using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver.Entities
{
    class Cell
    {
        public string Number { get; set; }
        public string Position { get; private set; }
        public bool Fixed { get; set; }


        public Cell(string row, string column, string number, bool _fixed)
        {
            Position = row + "," + column;
            Number = number;
            Fixed = _fixed;
        }
    }
}
