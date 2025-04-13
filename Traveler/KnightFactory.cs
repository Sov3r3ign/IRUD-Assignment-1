using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveler
{
    class KnightFactory : TravelerFactory
    {
        public override Traveler makingTraveler(string name)
        {
            return new Warrior(name);
        }
    }
}
