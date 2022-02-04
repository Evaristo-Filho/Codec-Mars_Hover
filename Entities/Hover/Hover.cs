namespace MarsHover.Hover

{
    public class Hover : IHover
    {
        private readonly Dictionary<string, int> direction;

        public Hover()
        {
            direction = new Dictionary<string, int>();
            direction.Add("N", 1);
            direction.Add("S", 3);
            direction.Add("E", 2);
            direction.Add("W", 4);

            Orientation = 1;
            X=1;
            Y=1;
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

        public int X { get; set; }
        public int Y { get; set; }

        public void Move()
        {

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