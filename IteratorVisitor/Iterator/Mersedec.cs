using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    class Mersedec : Car
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitMersedec(this);
        }
        public void Ride()
        {
            Console.WriteLine("едет");
        }
    }
}
