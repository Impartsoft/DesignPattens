using DesignPattens.StructuralPatterns.Decorator.CoffeeExample;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StructuralPatterns.Decorator.CarExample.Tests
{
    [TestClass()]
    public class DecoratorCoffeeTests
    {
        [TestMethod()]
        public void ShouldReturnBaseCoffeeCost()
        {
            ICoffee coffee = new BaseCoffee();
            Assert.AreEqual(1.50M, coffee.Cost);
        }

        [TestMethod()]
        public void ShouldReturnEspressoShotCoffeeCost()
        {
            ICoffee coffee = new BaseCoffee();
            var espressoShotcoffee = new EspressoShotDecorator(coffee);
            Assert.AreEqual(2.05M, espressoShotcoffee.Cost);
        }
    }
}