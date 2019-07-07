using Schulzy.Minesweeper.Domain.Utils;
using Schulzy.Minesweeper.Interface.GameArea;
using System.Collections.Generic;
using Unity;

namespace Schulzy.Minesweeper.Domain.Module
{
    internal class BombSetter : IBombSetter
    {
        public void SetBombs(IUnityContainer container)
        {
            
        }

        public void SetBombs(Field field, int minesCount)
        {
            HashSet<int[]> hs = new HashSet<int[]>();
            while (hs.Count != minesCount)
            {
                hs.Add(new int[] { Helper.GetRandomNumber(0, field.Rows), Helper.GetRandomNumber(0, field.Columns) });
            }
        }
    }
}