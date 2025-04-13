using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveler
{
    internal class Program
    {
        static void Main(string[] args)
        {


            TravelerFactory wizarding = new MageFactory();
            Traveler merlin = wizarding.makingTraveler("Merlin");
            merlin.Journeying();
            Console.WriteLine();
            TravelerFactory warrior = new KnightFactory();
            Traveler sove = warrior.makingTraveler("Sovereign");
            sove.Journeying();
            Console.WriteLine();
            TravelerFactory assassin = new RogueFactory();
            Traveler robin = assassin.makingTraveler("Robin");
            robin.Journeying();

            sove.Changeroute(new Fly());
            sove.Journeying();


            Console.ReadLine();
        }
    }
}
