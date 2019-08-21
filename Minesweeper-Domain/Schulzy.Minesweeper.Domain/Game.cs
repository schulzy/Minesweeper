using Schulzy.Minesweeper.Interface;
using Schulzy.Minesweeper.Interface.GameArea;
using Unity;

namespace Schulzy.Minesweeper.Domain
{
    internal sealed class Game : IGame
    {
        private IUnityContainer _container;
        IFieldManager _fieldManager;
        public Game(IUnityContainer container)
        {
            _container = container;
        }
        
        public IFieldManager FieldManager => _container.Resolve<IFieldManager>();

        public void NewGame(FieldSettings fieldSettings)
        {
            _container.RegisterInstance(fieldSettings);
            var fieldGenerator = _container.Resolve<IFieldGenerator>();
            fieldGenerator.Generate();
        }
    }
}
