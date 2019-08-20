namespace Schulzy.Minesweeper.Interface.GameArea
{
    public interface IFieldManager
    {
        Cell GetCell(int rowIndex, int columnIndex);
        void ChangeCellSelection(int rowIndex, int columnIndex);
    }
}
