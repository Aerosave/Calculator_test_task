using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_prog.Test
{
        [TestFixture]
        public class CalculatorTests
        {
            [Test]
            public void Additional_MustReturnsCorrectdValue()
            {
                var calculatorTest = new Calculator();
                Assert.That(calculatorTest.Additional(1, 1), Is.EqualTo(2));
            }
            [Test]
            public void Subtraction_MustReturnCorrectValue()
            {
                Calculator calculator = new Calculator();
                Assert.That(calculator.Subtraction(1, 1) == 0);
            }
            [Test]
            public void Miltiplication_MustReturnCorrectValue()
            {
                var calculator = new Calculator();
                Assert.That(calculator.Miltiplication(2, 2) == 4);
            }
            [Test]
            public void Division_MustReturnCorrectValue()
            {
                var calculator = new Calculator();
                Assert.That(calculator.Division(2, 1) == 2);
            }
            [Test]
            public void Division_MustThrowException()
            {
                var calculator = new Calculator();
                Assert.Throws<DivideByZeroException>(() => calculator.Division(1, 0));
            }
        }
    }


