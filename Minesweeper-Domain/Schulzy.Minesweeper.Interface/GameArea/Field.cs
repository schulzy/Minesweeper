using System;
namespace Schulzy.Minesweeper.Interface.GameArea
{
    public class Field
    {
        private Cell[,] _cells;

        public int Rows { get; }

        public int Columns { get; }

        public Cell this[int rowIndex, int columnIndex]
        {
            get
            {
                if (rowIndex < 0 || rowIndex >= Rows - 1)
                    throw new ArgumentOutOfRangeException(nameof(rowIndex));

                if (columnIndex < 0 || columnIndex >= Columns - 1)
                    throw new ArgumentOutOfRangeException(nameof(columnIndex));

                return _cells[rowIndex, columnIndex];
            }
            set
            {
                if (rowIndex < 0 || rowIndex >= Rows - 1)
                    throw new ArgumentOutOfRangeException(nameof(rowIndex));

                if (columnIndex < 0 || columnIndex >= Columns - 1)
                    throw new ArgumentOutOfRangeException(nameof(columnIndex));

                _cells[rowIndex, columnIndex] = value;
            }
        }

        public Field(FieldSettings fieldSettings)
        {
            Rows = fieldSettings.Rows;
            Columns = fieldSettings.Columns;
            _cells = new Cell[Rows, Columns];
        }

    }
}
