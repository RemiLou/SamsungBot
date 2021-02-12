using System;
using System.Collections.Generic;
using System.Text;

namespace SamsungBot
{
    public class Motion : IMotion
    {
        private int angle = 0;

        public bool Move(int distance)
        {
            throw new NotImplementedException();
        }

        public void Rotate(int angle)
        {
            throw new NotImplementedException();
        }

        public int GetAngle()
        {
            return angle;
        }
    }
}
