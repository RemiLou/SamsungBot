using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SamsungBot
{
    public class Processing
    {
        public IMotion _motion;
        private int[,] _tableau = new int[66, 66];
        private Position localPosition = new Position() { x = 2, y = 2 };


        public Processing(IMotion motion)
        {
            _motion = motion;
        }

        public void Scan()
        {
            _tableau[0, 0] = 0;
            while (IsExplored(_tableau))
            {
                var obstacle = _motion.Move(1);
                var lookAt = new Position(){x=0, y=0};
                var angle = _motion.GetAngle();

                if (!obstacle)
                {
                    switch (angle)
                    {
                        case 0:
                            lookAt.SetPosition(1,0);
                            break;
                        case 90:
                            lookAt.SetPosition(0, -1);
                            break;
                        case 180:
                            lookAt.SetPosition(-1, 0);
                            break;
                        case 270:
                            lookAt.SetPosition(0, 1);
                            break;
                    }
                    _tableau[lookAt.x, lookAt.y] = 1;

                    localPosition.x += lookAt.x;
                    localPosition.y += lookAt.y;

                }
                else
                {
                    _tableau[lookAt.x, lookAt.y] = -1;
                    _motion.Rotate(90);
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
