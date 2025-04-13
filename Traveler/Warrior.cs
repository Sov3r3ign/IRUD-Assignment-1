using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveler
{
    class Warrior : Traveler
    {
        public Warrior(string name) : base(name)
        {
            travelling = new Horse();
        }
    }
}
