namespace Schulzy.Minesweeper.Interface.GameArea
{
    public class Cell
    {
        public bool Visible { get; set; }
        public bool IsMine { get; set; }
        public bool IsSelected { get; set; }
        public int NeighbourMines { get; set; }

    }
}
