using System;
using System.Collections.Generic;
using System.Text;

namespace Schulzy.Minesweeper.Interface
{
    public class Cell
    {
        public bool Visible { get; set; }
        public bool IsMine { get; set; }
        public int NeighbourMines { get; set; }

    }
}
