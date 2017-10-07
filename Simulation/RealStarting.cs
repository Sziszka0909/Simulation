using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation
{
    public sealed class RealStarting
    {
        private static List<RealPlayer> realPlayers = new List<RealPlayer>();

        public static void addPlayersToStarting(RealPlayer player)
        {
            realPlayers.Add(player);
        }

        public static void getAllPlayers()
        {
            foreach(RealPlayer realPlayer in realPlayers)
            {
                Console.WriteLine(realPlayer);
            }
        }

        public static Player getPlayer(int index)
        {
            return realPlayers[index];
        }
    }
}
