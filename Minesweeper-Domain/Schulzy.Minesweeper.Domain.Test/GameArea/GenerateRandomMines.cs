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
                Generate_Z_Mines_InXxYField(rowCount: 3, columnCount: 3, mines: 3);
            }
        }

        [TestCase]
        public void Generate100Times_10Mines_In15x10Field()
        {
            for (int i = 0; i < 100; i++)
            {
                Generate_Z_Mines_InXxYField(rowCount: 10, columnCount: 15, mines: 10);
            }
        }

        [TestCase]
        public void Generate100Times_20Mines_In10x15Field()
        {
            for (int i = 0; i < 100; i++)
            {
                Generate_Z_Mines_InXxYField(rowCount: 15, columnCount: 10, mines: 20);
            }
        }

        private void Generate_Z_Mines_InXxYField(int rowCount, int columnCount, int mines)
        {
            // Arrange
            IUnityContainer container = new UnityContainer();
            FieldSettings fieldSettings = new FieldSettings() { Mines = mines, Rows = rowCount, Columns = columnCount };
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

            // Assert
            Assert.IsTrue(minesCount == mines);
        }
    }
}
