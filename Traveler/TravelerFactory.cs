using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveler
{
    abstract class TravelerFactory
    {
        public abstract Traveler makingTraveler(string name);
    }
}
