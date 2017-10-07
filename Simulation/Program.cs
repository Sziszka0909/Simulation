using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Simulation
{
    class Program
    {
        static void Main(string[] args)
        {
            RealPlayer ronaldo = new RealPlayer("Cristiano Ronaldo", 96, 97, 93, 94);
            RealPlayer benzema = new RealPlayer("Karim Benzema", 90, 91, 93, 87);
            RealPlayer bale = new RealPlayer("Gareth Bale", 91, 91, 90, 94);
            RealPlayer kroos = new RealPlayer("Toni Kroos", 88, 79, 93, 86);
            RealPlayer modric = new RealPlayer("Luka Modric", 88, 92, 81, 83);
            RealPlayer casemiro = new RealPlayer("Casemiro", 95, 80, 80, 89);
            RealPlayer marcelo = new RealPlayer("Marcelo", 78, 92, 91, 75);
            RealPlayer ramos = new RealPlayer("Sergio Ramos", 80, 88, 96, 92);
            RealPlayer varane = new RealPlayer("Raphael Varane", 75, 91, 76, 79);
            RealPlayer carvajal = new RealPlayer("Daniel Carvajal", 85, 93, 84, 86);
            RealPlayer navas = new RealPlayer("Keylor Navas", 93, 89, 90, 86);
            TottenhamPlayer kane = new TottenhamPlayer("Harry Kane", 90, 90, 91, 89);
            TottenhamPlayer alli = new TottenhamPlayer("Dele Alli", 87, 90, 90, 87);
            TottenhamPlayer eriksen = new TottenhamPlayer("Christian Eriksen", 85, 85, 85, 87);
            TottenhamPlayer dembele = new TottenhamPlayer("Moussa Dembele", 82, 90, 87, 80);
            TottenhamPlayer son = new TottenhamPlayer("Son Heung-Min", 88, 88, 80, 90);
            TottenhamPlayer rose = new TottenhamPlayer("Danny Rose", 94, 78, 75, 82);
            TottenhamPlayer vertonghen = new TottenhamPlayer("Jan Vertonghen", 88, 76, 77, 88);
            TottenhamPlayer sanchez = new TottenhamPlayer("Davinson Sanchez", 80, 80, 93, 82);
            TottenhamPlayer alderweireld = new TottenhamPlayer("Toby Alderweireld", 87, 90, 82, 86);
            TottenhamPlayer aurier = new TottenhamPlayer("Serge Aurier", 77, 88, 91, 81);
            TottenhamPlayer lloris = new TottenhamPlayer("Hugo Lloris", 91, 90, 92, 90);
            Logic logic = new Logic();
            Random random = new Random();
            int counter = 1;
            while(counter != 91)
            {
                if(counter%6 == 0 || counter%8 == 0 || counter%11 == 0)
                {
                    int team = random.Next(1, 3);
                    if(team == 1)
                    {
                        logic.realChance(random, counter);
                    } else
                    {
                        logic.tottenhamChance(random, counter);
                    }
                } else
                {
                    Console.WriteLine(counter + ". perc.");
                }
                counter++;
                Thread.Sleep(2000);
            }
            Console.WriteLine("Végeredmény: " + logic.RealGoal + "-" + logic.TottenhamGoal + ".");
            logic.printScorers();
            Console.ReadLine();
        }
    }
}
