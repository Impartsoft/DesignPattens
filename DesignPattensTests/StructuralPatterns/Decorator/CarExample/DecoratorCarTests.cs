using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPattens.StructuralPatterns.Decorator.CarExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator.CarExample.Tests
{
    [TestClass()]
    public class DecoratorCarTests
    {
        [TestMethod()]
        public void ShouldReturnBaseCar()
        {
            ICar car = new BaseCar();
            Assert.AreEqual(100, car.Drive());
            Assert.AreEqual(100, car.Attack());
            Assert.AreEqual(100, car.Defend());
        }

        [TestMethod()]
        public void ShouldReturnArmoredCar()
        {
            ICar baseCar = new BaseCar();
            ICar car = new ArmoredCar(baseCar);
            Assert.AreEqual(80, car.Drive());
            Assert.AreEqual(100, car.Attack());
            Assert.AreEqual(140, car.Defend());
        }

        [TestMethod()]
        public void ShouldReturnRaceCar()
        {
            var baseCar = new BaseCar();
            var car = new RaceCar(baseCar);
            Assert.AreEqual(140, car.Drive());
            Assert.AreEqual(90, car.Attack());
            Assert.AreEqual(90, car.Defend());
        }

        [TestMethod()]
        public void ShouldReturnAttackCar()
        {
            var baseCar = new BaseCar();
            var car = new AttackCar(baseCar);
            Assert.AreEqual(90, car.Drive());
            Assert.AreEqual(130, car.Attack());
            Assert.AreEqual(90, car.Defend());
        }

        [TestMethod()]
        public void ShouldReturnFullyDecoratedRaceCar()
        {
            var baseCar = new BaseCar();
            var armoredCar = new ArmoredCar(baseCar);
            var armoredCar2 = new ArmoredCar(armoredCar);
            var raceCar = new RaceCar(armoredCar2);
            ICar car = new AttackCar(raceCar);
            Assert.AreEqual(90, car.Drive());
            Assert.AreEqual(120, car.Attack());
            Assert.AreEqual(160, car.Defend());
        }
    }
}