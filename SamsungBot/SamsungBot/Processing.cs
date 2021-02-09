using System;
using System.Collections.Generic;
using System.Text;

namespace SamsungBot
{
    public class Processing
    {
        public IMotion _motion;

        public Processing(IMotion motion)
        {
            _motion = motion;
        }

        public void Scan()
        {
            _motion.Move(1);
        }
    }
}
