using Schulzy.Minesweeper.Interface;
using Unity;
namespace Schulzy.Minesweeper.Domain
{
    internal class FieldGenerator : IFieldGenerator
    {
        private readonly IUnityContainer _container;
        private FieldSettings _fieldSettings;

        public FieldGenerator(IUnityContainer container)
        {
            _container = container;
        }

        public void Generate()
        {
            throw new System.NotImplementedException();
        }

        public void Initialize(FieldSettings fieldSettings)
        {
            _fieldSettings = fieldSettings;
        }
    }
}
