using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class HandDamage : IDamage
    {
        public void Kick()
        {
            Console.WriteLine("Удар рукой");
        }
    }
}
