using MarsHover.Hover;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsHover.Terrain
{
    public class Terrain : ITerrain
    {

        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        public Terrain(int X, int Y, IHover hover)
        {
            this.XCoordinate = X;
            this.YCoordinate = Y;
        }

    }
}
