﻿using Schulzy.Minesweeper.Interface.GameArea;
using System;
using Unity;

namespace Schulzy.Minesweeper.Domain.GameArea
{
    internal class FieldManager : IFieldManager
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

            return _field[columnIndex, rowIndex];
        }

        public void ChangeCellSelection(int rowIndex, int columnIndex)
        {
            if (rowIndex < 0 || rowIndex >= _field.Rows - 1)
                throw new ArgumentOutOfRangeException(nameof(rowIndex));

            if (columnIndex < 0 || columnIndex >= _field.Columns - 1)
                throw new ArgumentOutOfRangeException(nameof(columnIndex));

            _field[columnIndex, rowIndex].IsSelected = !_field[columnIndex, rowIndex].IsSelected;
        }
    }
}
