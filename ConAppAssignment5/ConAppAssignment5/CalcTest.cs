using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment5
{
    [TestFixture]
    public class CalcTest
    {
        [Test]
        public void AddTest()
        {
            Calc cal = new Calc();
            double num1 = 10;
            double num2 = 10;

            double result = num1 + num2;

            Assert.AreEqual(result, cal.Add(10, 10));
        }

        [Test]
        public void SubTractTest()
        {
            Calc cal = new Calc();
            double num1 = 10;
            double num2 = 10;

            double result = num1 - num2;

            Assert.AreEqual(result, cal.Sub(10, 10));
        }

        [Test]
        public void DivideTest()
        {
            Calc cal = new Calc();
            double num1 = 10;
            double num2 = 10;

            double result = num1 / num2;

            Assert.AreEqual(result, cal.Div(10, 10));
        }

        [Test]
        public void MultiplyTest()
        {
            Calc cal = new Calc();
            double num1 = 10;
            double num2 = 10;

            double result = num1 * num2;

            Assert.AreEqual(result, cal.Mul(10, 10));
        }
    }
}

