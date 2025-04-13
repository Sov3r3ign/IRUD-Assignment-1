using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveler
{
    class Traveler
    {

        public Travel travelling;
        private string Name;
        public Traveler(string name)
        {
            this.Name = name;
        }
        public Traveler(Travel travelling)
        {
            this.travelling = travelling;
        }
        public void Changeroute(Travel route)
        {
            travelling = route;
        }
        public void Journeying()
        {
            Console.WriteLine(travelling.Move(Name));

        }
    }
}
