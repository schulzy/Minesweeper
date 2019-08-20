using Schulzy.Minesweeper.Domain.Module;
using Schulzy.Minesweeper.Interface;
using Schulzy.Minesweeper.Interface.GameArea;
using Schulzy.Minesweeper.UI.Winforms.Controller;
using Schulzy.Minesweeper.UI.Winforms.View;
using Unity;

namespace Schulzy.Minesweeper.Launcher
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();

            // Init field
            FieldSettings fieldSettings = new FieldSettings() { Columns = 10, Rows = 10, Mines = 10 };
            container.RegisterInstance(fieldSettings);
            var moduleRegister = new ModuleRegister(container);

            var fieldGenerator = container.Resolve<IFieldGenerator>();
            fieldGenerator.Generate();

            var field = container.Resolve<Field>();

            fieldSettings = new FieldSettings() { Columns = 20, Rows = 20, Mines = 20 };
            container.RegisterInstance(fieldSettings);

            fieldGenerator.Generate();

            field = container.Resolve<Field>();

            var game = container.Resolve<IGame>();
            IFieldView view = new FieldView();
            FieldController controller = new FieldController(view, game);
        }
    }
}
