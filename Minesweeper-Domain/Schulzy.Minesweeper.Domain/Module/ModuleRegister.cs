using Schulzy.Minesweeper.Domain.GameArea;
using Schulzy.Minesweeper.Interface;
using Schulzy.Minesweeper.Interface.GameArea;
using Unity;

namespace Schulzy.Minesweeper.Domain.Module
{
    public class ModuleRegister
    {
        public ModuleRegister(IUnityContainer dicontainer)
        {
            dicontainer.RegisterType<IMineSetter, MineSetter>();
            dicontainer.RegisterType<INeighbourMinesCalculator, NeighbourMinesCalculator>();
            dicontainer.RegisterType<IFieldGenerator,FieldGenerator>();
            dicontainer.RegisterType<IFieldManager, FieldManager>();
            dicontainer.RegisterType<IGame,Game>();
        }
    }
}
