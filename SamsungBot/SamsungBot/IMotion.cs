using System;
using System.Collections.Generic;
using System.Text;

namespace SamsungBot
{
    interface IMotion
    {
        bool Move(int distance);
        void Rotate(int angle);
    }
}
