using Schulzy.Minesweeper.Interface;
using Schulzy.Minesweeper.Interface.GameArea;
using Unity;

namespace Schulzy.Minesweeper.Domain
{
    internal sealed class Game : IGame
    {
        IFieldManager _fieldManager;
        public Game(IUnityContainer container)
        {
            _fieldManager = container.Resolve<IFieldManager>();
        }
        
        public IFieldManager FieldManager => _fieldManager;

        public void NewGame(FieldSettings fieldSettings)
        {
            throw new System.NotImplementedException();
        }
    }
}
