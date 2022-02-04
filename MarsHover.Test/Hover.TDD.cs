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
        public void RotateRight()
        {
            hover.Rotate("R");
            if (hover.Orientation != 2)
                Assert.Fail("Rover position is wrong");
            hover.Rotate("R");
            hover.Rotate("R");
            hover.Rotate("R");
            if (hover.Orientation != 1)
                Assert.Fail("Hover orientetion is wrong");

        }

        [TestMethod]
        public void RotateLeft()
        {
            hover.Rotate("L");
            if (hover.Orientation != 4)
                Assert.Fail("Rover position is wrong");
        }

    }
}