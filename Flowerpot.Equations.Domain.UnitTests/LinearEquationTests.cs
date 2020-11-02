using NUnit.Framework;

namespace Flowerpot.Equations.Domain.UnitTests
{
    public class LinearEquationTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldReturnValidResult()
        {
            var equation = new LinearEquation(4, -12);
            Assert.AreEqual(3, equation.CalcResult());
        }

        [Test]
        public void ShouldReturnValidEquationFormWithPositiveAAndB()
        {
            var equation = new LinearEquation(2, 4);
            Assert.AreEqual("2x + 4 = 0", equation.ToString());
        }

        [Test]
        public void ShouldReturnValidEquationFormWithPositiveAAndNegativeB()
        {
            var equation = new LinearEquation(2, -4);
            Assert.AreEqual("2x - 4 = 0", equation.ToString());
        }

        [Test]
        public void ShouldReturnValidEquationFormWithNegativeAAndPositiveB()
        {
            var equation = new LinearEquation(-2, 4);
            Assert.AreEqual("- 2x + 4 = 0", equation.ToString());
        }

        [Test]
        public void ShouldReturnValidEquationFormWithNegativeAAndB()
        {
            var equation = new LinearEquation(-2, -4);
            Assert.AreEqual("- 2x - 4 = 0", equation.ToString());
        }

        [Test]
        public void ShouldReturnValidEquationFromWithoutBFactor()
        {
            var equation = new LinearEquation(2, 0);
            Assert.AreEqual("2x = 0", equation.ToString());
        }

        [Test]
        public void ShouldThrowNonLinearEquation()
        {
            Assert.Throws<NonLinearEquationException>(() => new LinearEquation(0, 2));
        }

        [Test]
        public void ShouldThrowNonLinearEquationAndBIsEqualZero()
        {
            Assert.Throws<NonLinearEquationException>(() => new LinearEquation(0, 0));
        }
    }
}