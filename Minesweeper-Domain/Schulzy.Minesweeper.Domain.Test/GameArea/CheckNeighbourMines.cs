using NUnit.Framework;
using Schulzy.Minesweeper.Domain.Module;
using Schulzy.Minesweeper.Domain.Test.GameArea.MockObjects;
using Schulzy.Minesweeper.Interface.GameArea;
using Unity;

namespace Schulzy.Minesweeper.Domain.Test.GameArea
{
    [TestFixture]
    internal class CheckNeighbourMines
    {
        [TestCase]
        public void Simple3x3FieldWith1MineInMiddle()
        {
            // Arrange
            IUnityContainer container = new UnityContainer();
            FieldSettings fieldSettings = new FieldSettings() { Mines = 1, Rows = 3, Columns = 3 };
            container.RegisterInstance(fieldSettings);
            container.RegisterType<IMineSetter, MineSetter3x3With1Mine>();
            container.RegisterType<INeighbourMinesCalculator, NeighbourMinesCalculator>();
            var fieldGenerator = new FieldGenerator(container);

            // Act
            fieldGenerator.Generate();
            var field = container.Resolve<Field>();

            // Assert
            int[,] solution = new int[,] { { 1, 1, 1 }, { 1, 0, 1 }, { 1, 1, 1 } };
            for (int columnIndex = 0; columnIndex < field.Columns; columnIndex++)
            {
                for (int rowIndex = 0; rowIndex < field.Rows; rowIndex++)
                {
                    Assert.IsTrue(field[columnIndex, rowIndex].NeighbourMines == solution[columnIndex, rowIndex]);
                }
            }
        }
    }
}
