using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    class Toyota : Car
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitToyota(this);
        }
        public void OpenDoor()
        {
            Console.WriteLine("открывает дверь");
        }
    }
}
