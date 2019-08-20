using Schulzy.Minesweeper.Interface.GameArea;

namespace Schulzy.Minesweeper.Interface
{
    public interface IGame
    {
        IFieldManager FieldManager { get; }
        void NewGame(FieldSettings fieldSettings);
    }
}
