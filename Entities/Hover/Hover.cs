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

            
        }

        public int Orientation { get; set; }


        public void Move()
        {
            throw new NotImplementedException();
        }

        public void Rotate(string Direction)
        {
            throw new NotImplementedException();
        }
    }
}