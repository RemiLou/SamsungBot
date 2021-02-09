using System;
using System.Collections.Generic;
using System.Text;

namespace SamsungBot
{
    public class Processing
    {
        public IMotion _motion;
        private int[,] _tableau = new int[66, 66];
        private Position localPosition = new Position() { x = 2, y = 2 };
        private int angle = 90;

        public Processing(IMotion motion)
        {
            _motion = motion;
        }

        public void Scan()
        {
            while (IsExplored(_tableau))
            {
                var obstacle = _motion.Move(1);

                if (!obstacle)
                {
                    if (angle)
                }
            }
        }

        private bool IsExplored(int[,] tab)
        {
            bool explored = true;

            for (int i = 0; i < tab.GetLength(0); i++)
                for(int j = 0; j < tab.GetLength(1); j++)
                    if (tab[i, j] == 0)
                        explored = false;

            return explored;
        }
    }
}
