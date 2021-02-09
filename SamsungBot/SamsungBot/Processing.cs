using System;
using System.Collections.Generic;
using System.Text;

namespace SamsungBot
{
    public class Processing
    {
        public IMotion _motion;
        int[,] tableau = new int[66,66];

        public Processing(IMotion motion)
        {
            _motion = motion;
        }

        public void Scan()
        {
            
            _motion.Move(1);
            _motion.Rotate(45);
        }
    }
}
