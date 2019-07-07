using Schulzy.Minesweeper.Interface.GameArea;

namespace Schulzy.Minesweeper.Domain.Test.GameArea.MockObjects
{
    internal class MineSetter3x3With1Mine : IMineSetter
    {
        public void SetMines(Field field, int minesCount)
        {
            field[1, 1].IsMine = true;
        }
    }
}
