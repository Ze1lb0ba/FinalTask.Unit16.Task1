using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask.Unit16.Task1.Tests
{
    [TestFixture]
    public class CalculatorTests
    {

        Calculator calc = new Calculator();

        [Test]
        public void AdditionalTests()
        {
            Assert.That(calc.Additional (3, 2) == 5);
        }

        [Test]
        public void SubstractionTests()
        {
            Assert.That(calc.Subtraction(300, 10) == 290); 
        }

        [Test]
        public void MultiplicationTests()
        {
            Assert.That(calc.Miltiplication(5, 5) == 25);
        }

        [Test]
        public void DivisionTests()
        {
            Assert.That(calc.Division(10,2)== 5);
        }
    }
}
