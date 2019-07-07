using NUnit.Framework;
using Schulzy.Minesweeper.Domain.Module;
using Schulzy.Minesweeper.Interface.GameArea;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace Schulzy.Minesweeper.Domain.Test.GameArea
{
    [TestFixture]
    internal class GenerateRandomMines
    {
        [TestCase]
        public void Generate100Times_3Mines_In3x3Field()
        {
            for (int i = 0; i < 100; i++)
            {
                Generate_3Mines_In3x3Field();
            }
        }

        private void Generate_3Mines_In3x3Field()
        {
            // Arrange
            IUnityContainer container = new UnityContainer();
            FieldSettings fieldSettings = new FieldSettings() { Mines = 3, Rows = 3, Columns = 3 };
            container.RegisterInstance(fieldSettings);
            container.RegisterType<IMineSetter, MineSetter>();
            container.RegisterType<INeighbourMinesCalculator, NeighbourMinesCalculator>();
            var fieldGenerator = new FieldGenerator(container);

            // Act
            fieldGenerator.Generate();
            var field = container.Resolve<Field>();
            int minesCount = 0;
            for (int columnIndex = 0; columnIndex < field.Columns; columnIndex++)
            {
                for (int rowIndex = 0; rowIndex < field.Rows; rowIndex++)
                {
                    if (field[columnIndex, rowIndex].IsMine)
                        minesCount++;
                }
            }

            Assert.IsTrue(minesCount == 3);
        }
    }
}
