using MarsHover.Terrain;

namespace MarsHover.Hover

{
    public class Hover : IHover
    {
        public readonly Dictionary<string, int> direction;
        private readonly ITerrain terrain;
        public Hover(ITerrain terrain)
        {
            direction = new Dictionary<string, int>();
            direction.Add("North", 1);
            direction.Add("South", 3);
            direction.Add("East", 2);
            direction.Add("West", 4);
            this.terrain = terrain;
            Orientation = 1;
            X = 1;
            Y = 1;
        }
        private int orientation;
        public int Orientation
        {
            get { return orientation; }
            private set
            {
                switch (value)
                {
                    case 5:
                        orientation = 1;
                        break;

                    case 0:
                        orientation = 4;
                        break;
                    default:
                        orientation = value;
                        break;
                }
            }
        }

        public void Run(string commands)
        {
            commands = commands.ToLower();
            var cmd = commands.ToArray();

            foreach (var c in cmd)
            {
                if (c == 'f')
                    this.Move();
                else
                    this.Rotate(c.ToString());

            }
        }

        public int X { get; set; }
        public int Y { get; set; }

        public void Move()
        {
            switch (Orientation)
            {
                case 1:
                    {
                        if (Y + 1 <= terrain.YCoordinate)
                            Y++;

                        break;
                    }
                case 2:
                    {
                        if (X + 1 <= terrain.XCoordinate)
                            X++;
                        break;
                    }
                case 3:
                    {
                        if (Y - 1 >= 0)
                            Y--;
                        break;
                    }
                case 4:
                    {
                        if (X - 1 >= 0)
                            X--;
                        break;
                    }
            }
        }

        public bool Rotate(string direction)
        {
            if (!direction.Equals("R", StringComparison.InvariantCultureIgnoreCase) && !direction.Equals("L", StringComparison.InvariantCultureIgnoreCase))
                return false;
            if (direction.Equals("R", StringComparison.InvariantCultureIgnoreCase))
                Orientation++;
            else
                Orientation--;
            return true;
        }
    }
}