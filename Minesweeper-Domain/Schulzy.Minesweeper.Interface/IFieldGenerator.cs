namespace Schulzy.Minesweeper.Interface
{
    public interface IFieldGenerator
    {
        void Initialize(FieldSettings fieldSettings);
        void Generate();
    }
}