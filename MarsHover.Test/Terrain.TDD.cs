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
                this.terrain = new Terrain.Terrain(5,5);
        }

        [TestMethod]
        public void TestTerrain()
        {
            //Must have at least one position
            if (terrain.XCoordinate < 1)
                Assert.Fail();
            //Must Have at leat one position
            if (terrain.XCoordinate < 1)
                Assert.Fail();
        }

    }
}