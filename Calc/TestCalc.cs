/*
 * Класс TestCalculator
 * Содержит тесты для класса Calculator
*/

using NUnit.Framework;

namespace Calc.Test
{

    [TestFixture]
    class TestCalculator
    {
        [Test]
        static public void SampleTest()
        {
            Assert.AreEqual(Calc.GetExpressionsResult("2*2"), "4");
        }

        [Test]
        static public void TestSum()
        {
            Assert.AreEqual(Calc.GetExpressionsResult("15+20"), "35");
        }

        [Test]
        static public void TestDifference()
        {
            Assert.AreEqual(Calc.GetExpressionsResult("15-20"), "-5");
        }

        [Test]
        static public void TestMultiplication()
        {
            Assert.AreEqual(Calc.GetExpressionsResult("15*20"), "300");
        }

        [Test]
        static public void TestDivision()
        {
            Assert.AreEqual(Calc.GetExpressionsResult("15/20"), "0,75");
        }

        [Test]
        static public void TestDivision2()
        {
            Assert.AreEqual(Calc.GetExpressionsResult("15/0"), "бесконечность");
        }

        [Test]
        static public void TestBrackets()
        {
            Assert.AreEqual(Calc.GetExpressionsResult("(12+(156*8)-23/8)+(123*45+(45.25-28+(123*0.5)))"), "6870,875");
        }
    }
}
