using MarsHover.Hover;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsHover.Test
{
    [TestClass]
    public class Hover
    {
        private IHover hover;
        public Hover()
        {
            if (hover == null)
                hover = new MarsHover.Hover.Hover();
        }

        [TestMethod]
        public void InitialPosition()
        {
            Assert.AreEqual(1, hover.Orientation);
        }

            [TestMethod]
        public void MoveHover()
        {
            Assert.Fail();
        }


        

        [TestMethod]
        public void RotateHover()
        {
            
        }

    }
}