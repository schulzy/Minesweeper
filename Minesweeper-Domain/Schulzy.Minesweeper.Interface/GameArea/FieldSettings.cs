namespace Schulzy.Minesweeper.Interface.GameArea
{
    public class FieldSettings
    {
        public int Columns { get; }
        public int Rows { get; }
        public int Mines { get; }

        public FieldSettings(int columns, int rows, int mines)
        {
            Columns = columns;
            Rows = rows;
            Mines = mines;
        }
    }
}
