using System;

namespace Schulzy.Minesweeper.Domain.Utils
{
    internal static class Helper
    {
        private static readonly Random _getrandom = new Random();

        public static int GetRandomNumber(int min, int max)
        {
            lock (_getrandom) 
            {
                return _getrandom.Next(min, max);
            }
        }
    }
}
