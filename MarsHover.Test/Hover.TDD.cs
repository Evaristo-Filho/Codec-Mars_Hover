using MarsHover.Hover;
using MarsHover.Terrain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsHover.Test
{
    [TestClass]
    public class Hover
    {
        private IHover hover;
        private ITerrain terrain;
        public Hover()
        {
            if (hover == null)
                hover = new MarsHover.Hover.Hover();
            terrain = new Terrain.Terrain(5, 5, hover);
        }

        [TestMethod]
        public void InitialOrientation()
        {
            Assert.AreEqual(1, hover.Orientation);
        }

        [TestMethod]
        public void InitialPosition()
        {
            Assert.AreEqual(1, hover.X);
            Assert.AreEqual(1, hover.Y);
        }

        [TestMethod]
        public void TestMovement()
        {
            hover.Move();
            hover.Move();
            hover.Move();

            Assert.AreEqual(4, hover.Y);
            hover.Rotate("R");
            hover.Move();
            Assert.AreEqual(2, hover.X);

        }

        [TestMethod]
        public void MoveInsideTerrain()
        {
            hover.Rotate("L");
            hover.Move();
            Assert.AreEqual(1, hover.X);
            Assert.AreEqual(1, hover.Y);

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