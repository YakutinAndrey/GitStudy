using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    abstract class Visitor
    {
        public abstract void VisitBMW(BMW bmw);
        public abstract void VisitMersedec(Mersedec mersedec);
        public abstract void VisitToyota(Toyota toyota);
    }

    class ConcreteVisitor1 : Visitor
    {
        public override void VisitBMW(BMW bmw)
        {
            bmw.Beep();
        }

        public override void VisitMersedec(Mersedec mersedec)
        {
            mersedec.Ride();
        }

        public override void VisitToyota(Toyota toyota)
        {
            toyota.OpenDoor();
        }
    }
    interface IElement
    {
        public abstract void Accept(Visitor visitor);
        
    }
}
