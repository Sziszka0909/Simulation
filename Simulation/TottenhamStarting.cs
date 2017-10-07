using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation
{
    public sealed class TottenhamStarting
    {
        private static List<TottenhamPlayer> tottenhamPlayers = new List<TottenhamPlayer>();

        public static void addPlayersToStarting(TottenhamPlayer tottenhamPlayer)
        {
            tottenhamPlayers.Add(tottenhamPlayer);
        }

        public static void getAllPlayers()
        {
            foreach(TottenhamPlayer tottenhamplayer in tottenhamPlayers)
            {
                Console.WriteLine(tottenhamplayer);
            }
        }

        public static Player getPlayer(int index)
        {
            return tottenhamPlayers[index];
        }
    }
}
