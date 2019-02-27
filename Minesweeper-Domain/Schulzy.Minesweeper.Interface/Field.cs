namespace Schulzy.Minesweeper.Interface
{
    public class Field
    {
        private int _rows;
        private int _columns;
        private Cell[,] _cells;

        public Field(int rows, int columns)
        {
            _rows = rows;
            _columns = columns;
            _cells = new Cell[rows, columns];
        }
    }
}
