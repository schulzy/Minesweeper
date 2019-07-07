using Schulzy.Minesweeper.Interface.GameArea;
using Unity;
namespace Schulzy.Minesweeper.Domain
{
    internal class FieldGenerator : IFieldGenerator
    {
        private readonly IUnityContainer _container;
        private FieldSettings _fieldSettings;
        private INeighbourMinesCalculator _neighbourBombCalculator;
        private IMineSetter _bombSetter;

        public FieldGenerator(IUnityContainer container)
        {
            _container = container;
            _fieldSettings = _container.Resolve<FieldSettings>();
            _neighbourBombCalculator = container.Resolve<INeighbourMinesCalculator>();
            _bombSetter = container.Resolve<IMineSetter>();
        }

        public void Generate()
        {
            var field = new Field(_container.Resolve<FieldSettings>());
            _bombSetter.SetMines(field,_fieldSettings.Mines);
            _neighbourBombCalculator.CalculateNeighbourMines(field);
            _container.RegisterInstance<Field>(field);
        }
    }
}
