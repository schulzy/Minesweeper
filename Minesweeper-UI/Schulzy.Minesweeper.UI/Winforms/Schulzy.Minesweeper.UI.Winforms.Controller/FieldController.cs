using Schulzy.Minesweeper.Interface;
using Schulzy.Minesweeper.Interface.GameArea;

namespace Schulzy.Minesweeper.UI.Winforms.Controller
{
    public class FieldController
    {
        private IFieldView _fieldView;
        private IGame _game;

        public FieldController(IFieldView fieldView, IGame game)
        {
            _fieldView = fieldView;
            _game = game;
        }

        public void StartNewGame(FieldSettings fieldSettings)
        {
            _game.NewGame(fieldSettings);
        }
    }
}