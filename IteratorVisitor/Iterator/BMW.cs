using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    class BMW : Car
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitBMW(this);

        }
        public void Beep()
        {
            Console.WriteLine("сигналит");
        }
    }
}
