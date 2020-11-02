using NUnit.Framework;

namespace Flowerpot.Equations.Domain.UnitTests
{
    public class QuadraticEquationTests
    {
        [SetUp]
        public void Setup()
        { }

        #region Two roots
        [Test]
        public void ShouldHasValidFirstRoot()
        {
            var equation = new QuadraticEquation(2, -4, 0);
            var result = equation.CalcResults();
            Assert.AreEqual(0, result.FirstRoot);
        }

        [Test]
        public void ShouldHasValidSecondRoot()
        {
            var equation = new QuadraticEquation(2, -4, 0);
            var result = equation.CalcResults();
            Assert.AreEqual(2, result.SecondRoot);
        }

        [Test]
        public void ShouldHasTwoRoots()
        {
            var equation = new QuadraticEquation(2, -4, 0);
            var result = equation.CalcResults();
            Assert.True(result.HasTwoRoots());
        }

        [Test]
        public void ShouldHasDeltaGreaterThanZero()
        {
            var equation = new QuadraticEquation(2, -4, 0);
            var delta = equation.CalcDelta();
            Assert.Greater(delta, 0);
        }
        #endregion

        #region One root

        [Test]
        public void ShouldHasOneValidResult()
        {
            var equation = new QuadraticEquation(2, -4, 2);
            var result = equation.CalcResults();
            Assert.AreEqual(1, result.OnlyRoot);
        }

        [Test]
        public void ShouldHasOneRoot()
        {
            var equation = new QuadraticEquation(2, -4, 2);
            var result = equation.CalcResults();
            Assert.True(result.HasOneRoot());
        }

        [Test]
        public void ShouldHasDeltaEqualZero()
        {
            var equation = new QuadraticEquation(2, -4, 2);
            var delta = equation.CalcDelta();
            Assert.AreEqual(delta, 0);
        }


        #endregion

        #region No roots
        [Test]
        public void ShouldNonRoot()
        {
            var equation = new QuadraticEquation(2, -2, 2);
            var result = equation.CalcResults();
            Assert.True(result.HasNoRoots());
        }

        [Test]
        public void ShouldHasDeltaLessThanZero()
        {
            var equation = new QuadraticEquation(2, -2, 2);
            var delta = equation.CalcDelta();
            Assert.Less(delta, 0);
        }
        #endregion

        #region Exceptions
        [Test]
        public void ShouldThrowExceptionIfIsNotQuadratic()
        {
            Assert.Catch<NonQuadraticEquationException>(() => new QuadraticEquation(0, 1, 3));
        }
        #endregion
    }
}
