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

        public Terrain(int X, int Y)
        {
            this.XCoordinate = X;
            this.YCoordinate = Y;
        }
        public Terrain() { }

        public bool PepareTerrain(string command)
        {
            command = command.ToLower();
            var splitedcommand = command.Split('x');
            try
            {
                this.XCoordinate = int.Parse(splitedcommand[0]);
                this.YCoordinate = int.Parse(splitedcommand[1]);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
