namespace Schulzy.Minesweeper.UI.Winforms.Controller
{
    public interface IFieldView
    {
        void SetController(FieldController controller);

        void StartNewGame();

        int Columns { get; }

        int Rows { get; }

        int Mines { get; }
    }
}
