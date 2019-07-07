using System;
using System.Linq;

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
                if (rowIndex < 0 || rowIndex >= Rows)
                    throw new ArgumentOutOfRangeException(nameof(rowIndex));

                if (columnIndex < 0 || columnIndex >= Columns)
                    throw new ArgumentOutOfRangeException(nameof(columnIndex));

                return _cells[rowIndex, columnIndex];
            }
            set
            {
                if (rowIndex < 0 || rowIndex >= Rows)
                    throw new ArgumentOutOfRangeException(nameof(rowIndex));

                if (columnIndex < 0 || columnIndex >= Columns)
                    throw new ArgumentOutOfRangeException(nameof(columnIndex));

                _cells[rowIndex, columnIndex] = value;
            }
        }

        public Field(FieldSettings fieldSettings)
        {
            Rows = fieldSettings.Rows;
            Columns = fieldSettings.Columns;

            _cells = new Cell[Rows, Columns];
            for (int i = 0; i < Columns; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    _cells[i, j] = new Cell();
                }
            }
        }

    }
}
