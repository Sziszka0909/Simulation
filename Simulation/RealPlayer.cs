using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation
{
    public class RealPlayer : Player
    {
        public RealPlayer(string name, int topRight, int topLeft, int bottomRight, int bottomLeft) : base(name, topRight, topLeft, bottomRight, bottomLeft)
        {
            RealStarting.addPlayersToStarting(this);
        }
    }
}
