

namespace SudokuSolver.Entities
{
    class Cell
    {
        public string Number { get; set; }
        public string Position { get; private set; }
        public bool Fixed { get; private set; }
        public int BoxNumber { get; private set; }

        public Cell(string row, string column)
        {
            Position = row + "," + column;
        }

        public Cell(string row, string column, string number, bool _fixed, int boxnumber)
        {
            Position = row + "," + column;
            Number = number;
            Fixed = _fixed;
            BoxNumber = boxnumber;
        }
    }
}