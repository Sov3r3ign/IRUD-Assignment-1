using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveler
{
    class Assassin : Traveler
    {
        public Assassin(string name) : base(name)
        {
            travelling = new Walk();
        }
    }
}
