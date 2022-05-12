using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattens
{
    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(IComponent component) : base(component)
        {
 
        }

        public override void Operation()
        {
            throw new NotImplementedException();
        }
    }
}