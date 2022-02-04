using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsHover.Hover
{
    public interface IHover
    {
        public int X { get; set; }
        public int Y { get; set; }  
        public int Orientation { get; }
        void Move();
        bool Rotate(string Direction);
    }
}
