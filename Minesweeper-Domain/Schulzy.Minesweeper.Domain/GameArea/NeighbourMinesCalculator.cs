using System;
using Schulzy.Minesweeper.Interface.GameArea;

namespace Schulzy.Minesweeper.Domain.Module
{
    internal class NeighbourMinesCalculator : INeighbourMinesCalculator
    {
        public void CalculateNeighbourMines(Field field)
        {
            for (int columnIndex = 0; columnIndex < field.Columns; columnIndex++)
            {
                for (int rowIndex = 0; rowIndex < field.Rows; rowIndex++)
                {
                    field[columnIndex, rowIndex].NeighbourMines = SumNeighbours(field, columnIndex, rowIndex);
                }
            }
        }

        private int SumNeighbours(Field field, int columnIndex, int rowIndex)
        {
            int neighboursCount = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int tempColumnIndex = columnIndex + i;
                    int tempRowIndex = rowIndex + j;

                    if (tempColumnIndex < 0 || tempRowIndex < 0 || tempColumnIndex >= field.Columns - 1 || tempRowIndex >= field.Rows - 1)
                        continue;

                    if (i == 0 && j == 0)
                        continue;

                    if (field[tempColumnIndex, tempRowIndex].IsMine)
                        neighboursCount++;
                }
            }
            return neighboursCount;
        }
    }
}