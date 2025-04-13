using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveler
{
    class Horse : Travel
    {
        public override string Move(string name)
        {
            return $"{name} is galloping on a horse through the forest.";
        }
    }
}
