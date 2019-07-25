using System;
using System.Linq;

namespace Schulzy.Minesweeper.Interface.GameArea
{
    public class Field
    {
        private Cell[,] _cells;

        public int Rows { get; }

        public int Columns { get; }

        public Cell this[int columnIndex, int rowIndex]
        {
            get
            {
                if (rowIndex < 0 || rowIndex >= Rows)
                    throw new ArgumentOutOfRangeException(nameof(rowIndex));

                if (columnIndex < 0 || columnIndex >= Columns)
                    throw new ArgumentOutOfRangeException(nameof(columnIndex));

                return _cells[columnIndex, rowIndex];
            }
            set
            {
                if (rowIndex < 0 || rowIndex >= Rows)
                    throw new ArgumentOutOfRangeException(nameof(rowIndex));

                if (columnIndex < 0 || columnIndex >= Columns)
                    throw new ArgumentOutOfRangeException(nameof(columnIndex));

                _cells[columnIndex, rowIndex] = value;
            }
        }

        public Field(FieldSettings fieldSettings)
        {
            Rows = fieldSettings.Rows;
            Columns = fieldSettings.Columns;

            _cells = new Cell[Columns, Rows];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    _cells[j, i] = new Cell();
                }
            }
        }

    }
}
