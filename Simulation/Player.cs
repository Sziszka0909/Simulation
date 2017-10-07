using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation
{
    public class Player
    {
        string name;
        int topRight;
        int topLeft;
        int bottomRight;
        int bottomLeft;

        public Player(string name, int topRight, int topLeft, int bottomRight, int bottomLeft)
        {
            this.Name = name;
            this.TopRight = topRight;
            this.TopLeft = topLeft;
            this.BottomRight = bottomRight;
            this.BottomLeft = bottomLeft;
        }

        public string Name { get => name; set => name = value; }
        public int TopRight { get => topRight; set => topRight = value; }
        public int TopLeft { get => topLeft; set => topLeft = value; }
        public int BottomRight { get => bottomRight; set => bottomRight = value; }
        public int BottomLeft { get => bottomLeft; set => bottomLeft = value; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
