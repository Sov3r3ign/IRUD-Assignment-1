using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveler
{
    class Fly : Travel
    {
        public override string Move(string name)
        {
            return $"{name} is soaring through the skies";
        }
    }
}

