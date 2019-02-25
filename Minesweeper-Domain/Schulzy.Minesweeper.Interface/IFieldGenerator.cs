using Unity;

namespace Schulzy.Minesweeper.Interface
{
    public interface IFieldGenerator
    {
        void Initialize();
        void Generate();
    }
}