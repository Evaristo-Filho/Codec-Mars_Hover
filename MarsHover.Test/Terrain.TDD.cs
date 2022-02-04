using MarsHover.Terrain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsHover.Test
{
    [TestClass]
    public class TerrainTest
    {
        private ITerrain terrain;

        public TerrainTest()
        {
            if (this.terrain == null)
                this.terrain = new Terrain.Terrain(5, 5, new MarsHover.Hover.Hover(terrain));
        }

        [TestMethod]
        public void TestTerrain()
        {
            //Must have at least one position
            if (terrain.XCoordinate < 1)
                Assert.Fail("Invalid Coordinate: X component");
            //Must Have at leat one position
            if (terrain.XCoordinate < 1)
                Assert.Fail("invalid Coordinate: Y component");
        }

        [TestMethod]
        public void HoverPresence()
        {
            Assert.IsNotNull(terrain.FindHover(), "No hover present on terrain");
        }



    }
}