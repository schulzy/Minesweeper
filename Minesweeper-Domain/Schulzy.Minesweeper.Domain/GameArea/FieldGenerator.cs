using Schulzy.Minesweeper.Interface.GameArea;
using Unity;
namespace Schulzy.Minesweeper.Domain
{
    internal class FieldGenerator : IFieldGenerator
    {
        private readonly IUnityContainer _container;
        private FieldSettings _fieldSettings;
        private INeighbourBombCalculator _neighbourBombCalculator;
        private IBombSetter _bombSetter;

        public FieldGenerator(IUnityContainer container)
        {
            _container = container;
            _fieldSettings = _container.Resolve<FieldSettings>();
            _neighbourBombCalculator = container.Resolve<INeighbourBombCalculator>();
            _bombSetter = container.Resolve<IBombSetter>();
        }

        public void Generate()
        {
            var field = new Field(_container.Resolve<FieldSettings>());
            _bombSetter.SetBombs(field,_fieldSettings.Mines);
            _neighbourBombCalculator.CalculateNeighbourBombs(field);
            _container.RegisterInstance<Field>(field);
        }
    }
}
