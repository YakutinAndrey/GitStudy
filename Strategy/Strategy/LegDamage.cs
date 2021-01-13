using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class LegDamage : IDamage
    {
        public void Kick()
        {
            Console.WriteLine("Удар ногой");
        }
    }
}
