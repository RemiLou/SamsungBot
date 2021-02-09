using Microsoft.VisualStudio.TestTools.UnitTesting;
using SamsungBot;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class Test
    {
        private IMotion _motion;
        private Processing _processing;

        public Test(IMotion motion)
        {
            _motion = motion;
            _processing = new Processing(_motion);
        }

        [TestMethod]
        public void Move1()
        {
            _processing.Scan();
        }
    }
}
