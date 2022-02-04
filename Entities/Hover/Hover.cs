namespace MarsHover.Hover

{
    public class Hover : IHover
    {
        private readonly Dictionary<string, int> direction;

        private readonly Func<bool> move;
        public Hover(Func<bool> move=null)
        {
            direction = new Dictionary<string, int>();
            direction.Add("N", 1);
            direction.Add("S", 3);
            direction.Add("E", 2);
            direction.Add("W", 4);

            this.move = move;
            Orientation = 1;
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


        public void Move()
        {
            this.move();
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