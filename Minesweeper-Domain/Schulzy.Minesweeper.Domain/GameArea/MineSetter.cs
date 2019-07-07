using Schulzy.Minesweeper.Domain.Utils;
using Schulzy.Minesweeper.Interface.GameArea;
using System;
using System.Collections.Generic;
using Unity;

namespace Schulzy.Minesweeper.Domain.Module
{
    internal class MineSetter : IMineSetter
    {
        public void SetMines(Field field, int minesCount)
        {
            HashSet<int[]> hs = new HashSet<int[]>();
            Dictionary<string, int[]> dict = new Dictionary<string, int[]>();
            while (dict.Count != minesCount)
            {
                int[] pair = new int[] { Helper.GetRandomNumber(0, field.Columns), Helper.GetRandomNumber(0, field.Rows) };
                dict.TryAdd(string.Join(';', pair), pair);
            }

            foreach (var item in dict)
            {
                field[item.Value[0], item.Value[1]].IsMine = true;
            }
        }
    }
}