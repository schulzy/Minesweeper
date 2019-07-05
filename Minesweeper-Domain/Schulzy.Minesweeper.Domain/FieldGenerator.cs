using System;
using System.Collections.Generic;
using Schulzy.Minesweeper.Domain.Utils;
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
            _fieldSettings = _container.Resolve<FieldSettings>();
        }

        public void Generate()
        {
            var field = new Field(_container.Resolve<FieldSettings>());
            AddMines(field);
            CalculateNeighborBombs(field);
            _container.RegisterInstance<Field>(field);
        }

        private void CalculateNeighborBombs(Field field)
        {
            HashSet<int[]> hs = new HashSet<int[]>();
            while(hs.Count!= _fieldSettings.Mines)
            {
                hs.Add(new int[] { Helper.GetRandomNumber(0, field.Rows), Helper.GetRandomNumber(0, field.Columns) });
            }
        }

        private void AddMines(Field field)
        {
            throw new NotImplementedException();
        }
    }
}
