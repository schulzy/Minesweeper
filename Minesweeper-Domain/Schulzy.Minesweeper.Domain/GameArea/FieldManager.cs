using Schulzy.Minesweeper.Interface.GameArea;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace Schulzy.Minesweeper.Domain.GameArea
{
    internal class FieldManager
    {
        private Field _field;

        public FieldManager(IUnityContainer diContainer)
        {
            _field = diContainer.Resolve<Field>();
        }

        public Cell GetCell(int rowIndex, int columnIndex)
        {
            if (rowIndex < 0 || rowIndex >= _field.Rows - 1)
                throw new ArgumentOutOfRangeException(nameof(rowIndex));

            if (columnIndex < 0 || columnIndex >= _field.Columns - 1)
                throw new ArgumentOutOfRangeException(nameof(columnIndex));

            return _field[rowIndex, columnIndex];
        }

        public void ChangeCellSelection(int rowIndex, int columnIndex)
        {
            if (rowIndex < 0 || rowIndex >= _field.Rows - 1)
                throw new ArgumentOutOfRangeException(nameof(rowIndex));

            if (columnIndex < 0 || columnIndex >= _field.Columns - 1)
                throw new ArgumentOutOfRangeException(nameof(columnIndex));

            _field[rowIndex, columnIndex].IsSelected = !_field[rowIndex, columnIndex].IsSelected;
        }
    }
}
