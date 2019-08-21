using Schulzy.Minesweeper.UI.Winforms.Controller;
using System.Windows.Forms;

namespace Schulzy.Minesweeper.UI.Winforms.View
{
    public partial class FieldView : Form, IFieldView
    {
        private FieldController _controller;
        private int _columns;
        private int _rows;
        private int _mines;

        public FieldView()
        {
            InitializeComponent();
        }

        public int Columns { get => _columns; }
        public int Rows { get => _rows; }

        public int Mines { get => _mines; }

        public void SetController(FieldController controller)
        {
            _controller = controller;
        }

        public void StartNewGame()
        {
            _controller.StartNewGame(new Interface.GameArea.FieldSettings(Columns, Rows, Mines));
        }
    }
}
