using System;
using System.Collections.Generic;
using System.Text;

namespace SamsungBot
{
    public class Position
    {
        public int x { get; set; }
        public int y { get; set; }

        public void SetPosition(int xIn, int yIn)
        {
            x = xIn;
            y = yIn;
        }
    }
}
