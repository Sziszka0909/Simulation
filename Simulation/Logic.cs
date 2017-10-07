using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Simulation
{
    public sealed class Logic
    {
        int realGoal = 0;
        int tottenhamGoal = 0;
        Dictionary<int, string> goalScorers = new Dictionary<int, string>();

        public int RealGoal { get => realGoal; set => realGoal = value; }
        public int TottenhamGoal { get => tottenhamGoal; set => tottenhamGoal = value; }

        public void shot(Random random, int counter, Player player)
        {
            int place = random.Next(1, 5);
            Player lloris = TottenhamStarting.getPlayer(10);
            Player navas = RealStarting.getPlayer(10);
            if (player.GetType() == typeof(RealPlayer))
            {
                if (place == 1)
                {
                    if (player.TopRight > lloris.TopRight)
                    {
                        realScore(counter, player);
                    } else
                    {
                        llorisSave(player, lloris);
                    }
                }
                else if (place == 2)
                {
                    if (player.TopLeft > lloris.TopLeft)
                    {
                        realScore(counter, player);
                    }
                    else
                    {
                        llorisSave(player, lloris);
                    }
                }
                else if (place == 3)
                {
                    if (player.BottomRight > lloris.BottomRight)
                    {
                        realScore(counter, player);
                    }
                    else
                    {
                        llorisSave(player, lloris);
                    }
                }
                else
                {
                    if (player.BottomLeft > lloris.BottomLeft)
                    {
                        realScore(counter, player);
                    }
                    else
                    {
                        llorisSave(player, lloris);
                    }
                }
            } else
            {
                if (place == 1)
                {
                    if (player.TopRight > navas.TopRight)
                    {
                        tottenhamScore(counter, player);
                    }
                    else
                    {
                        navasSave(player, navas);
                    }
                }
                else if (place == 2)
                {
                    if (player.TopLeft > navas.TopLeft)
                    {
                        tottenhamScore(counter, player);
                    }
                    else
                    {
                        navasSave(player, navas);
                    }
                }
                else if (place == 3)
                {
                    if (player.BottomRight > navas.BottomRight)
                    {
                        tottenhamScore(counter, player);
                    }
                    else
                    {
                        navasSave(player, navas);
                    }
                }
                else
                {
                    if (player.BottomLeft > navas.BottomLeft)
                    {
                        tottenhamScore(counter, player);
                    }
                    else
                    {
                        navasSave(player, navas);
                    }
                }
            }
        }
        public void printScorers()
        {
            Console.WriteLine("Gólszerzők:");
            foreach(KeyValuePair<int, string> entry in goalScorers)
            {
                Console.WriteLine(entry.Key + "' " + entry.Value);
            }
        }

        public void realChance(Random random, int counter)
        {
            int penalty = random.Next(1, 11);
            if (penalty == 1)
            {
                Console.WriteLine(counter + " perc.");
                realPenalty(random, counter);
            }
            else
            {
                int who = random.Next(0, 10);
                Player realP = RealStarting.getPlayer(who);
                Console.WriteLine(counter + " perc.");
                shot(random, counter, realP);
            }
        }

        public void tottenhamChance(Random random, int counter)
        {
            int penalty = random.Next(1, 11);
            if (penalty == 1)
            {
                Console.WriteLine(counter + " perc.");
                tottenhamPenalty(random, counter);
            }
            else
            {
                int who = random.Next(0, 10);
                Player tottenhamP = TottenhamStarting.getPlayer(who);
                Console.WriteLine(counter + " perc.");
                shot(random, counter, tottenhamP);
            }
        }

        public void realScore(int counter, Player player)
        {
            RealGoal++;
            Console.WriteLine("GÓL!!! " + player.Name + " talál a kapuba. " + RealGoal + "-" + TottenhamGoal + ".");
            goalScorers.Add(counter, player.Name);
        }

        public void llorisSave(Player player, Player lloris)
        {
            Console.WriteLine(player.Name + " lő, de " + lloris.Name + " véd.");
        }

        public void tottenhamScore(int counter, Player player)
        {
            TottenhamGoal++;
            Console.WriteLine("GÓL!!! " + player.Name + " talál a kapuba. " + RealGoal + "-" + TottenhamGoal + ".");
            goalScorers.Add(counter, player.Name);
        }

        public void navasSave(Player player, Player navas)
        {
            Console.WriteLine(player.Name + " lő, de " + navas.Name + " véd.");
        }

        public void realPenalty(Random random, int counter)
        {
            Player ronaldo = RealStarting.getPlayer(0);
            Console.WriteLine("TIZENEGYES! " + ronaldo.Name + " fogja elvégezni a büntetőt.");
            Thread.Sleep(800);
            Console.WriteLine("...");
            Thread.Sleep(1500);
            shot(random, counter, ronaldo);
        }

        public void tottenhamPenalty(Random random, int counter)
        {
            Player kane = TottenhamStarting.getPlayer(0);
            Console.WriteLine("TIZENEGYES! " + kane.Name + " fogja elvégezni a büntetőt.");
            Thread.Sleep(800);
            Console.WriteLine("...");
            Thread.Sleep(1500);
            shot(random, counter, kane);
        }
    }
}
