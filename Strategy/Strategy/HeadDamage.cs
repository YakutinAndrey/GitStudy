using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class HeadDamage : IDamage
    {
        public void Kick()
        {
            Console.WriteLine("Удар головой");
        }
    }
}
