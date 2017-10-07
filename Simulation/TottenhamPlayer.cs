using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation
{
    public class TottenhamPlayer : Player
    {
        public TottenhamPlayer(string name, int topRight, int topLeft, int bottomRight, int bottomLeft) : base(name, topRight, topLeft, bottomRight, bottomLeft)
        {
            TottenhamStarting.addPlayersToStarting(this);
        }
    }
}
