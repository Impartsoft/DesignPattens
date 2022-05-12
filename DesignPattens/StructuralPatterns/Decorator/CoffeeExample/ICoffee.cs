using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens.StructuralPatterns.Decorator.CoffeeExample
{
    public interface ICoffee
    {
        decimal Cost { get; set; }
        List<string> Ingredients { get; set; }
    }
}
