using Schulzy.Minesweeper.UI.Winforms.Controller;
using System.Windows.Forms;

namespace Schulzy.Minesweeper.UI.Winforms.View
{
    public partial class FieldView : Form, IFieldView
    {
        private FieldController _controller;

        public FieldView()
        {
            InitializeComponent();
        }

        public void SetController(FieldController controller)
        {
            _controller = controller;
        }
    }
}
