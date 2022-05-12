using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattens
{
    public class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(IComponent component) : base(component)
        {
        }

        public override void Operation()
        {
            throw new NotImplementedException();
        }
    }
}