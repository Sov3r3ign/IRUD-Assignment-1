using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveler
{
     class Wizard : Traveler
    {
        public Wizard(string name) : base(name)
        {
            travelling = new Fly();
        }
    }
}
