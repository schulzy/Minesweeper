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
            _ = new ModuleRegister(container);
            
            var game = container.Resolve<IGame>();
            IFieldView view = new FieldView();
            FieldController controller = new FieldController(view, game);
        }
    }
}
