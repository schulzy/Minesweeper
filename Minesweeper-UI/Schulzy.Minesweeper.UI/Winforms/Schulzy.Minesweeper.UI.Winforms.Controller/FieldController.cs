using Schulzy.Minesweeper.Interface;

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
    }
}