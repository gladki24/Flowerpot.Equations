using System;
using Flowerpot.Equations.Domain.QuadraticEquation;
using Flowerpot.Equations.Infrastructure;

namespace Flowerpot.Equations.Domain.UnitTests
{
    [Equation]
    public class QuadraticEquation
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public QuadraticEquation(double a)
        {
            if (a == 0)
                throw new NonQuadraticEquationException();

            A = a;
            B = 0;
            C = 0;
        }

        public QuadraticEquation(double a, double b)
        {
            if (a == 0)
                throw new NonQuadraticEquationException();

            A = a;
            B = b;
            C = 0;
        }

        public QuadraticEquation(double a, double b, double c)
        {
            if (a == 0)
                throw new NonQuadraticEquationException();

            A = a;
            B = b;
            C = c;
        }

        public double CalcDelta() => Math.Pow(B, 2) - (4 * A * C);

        public QuadraticEquationResult CalcResults()
        {
            var delta = CalcDelta();

            if (delta < 0)
                return new QuadraticEquationResult();

            if (delta == 0)
                return new QuadraticEquationResult(CalcOnlyRoot());

            var x1 = CalcX1(delta);
            var x2 = CalcX2(delta);

            return x1 < x2 ? new QuadraticEquationResult(x1, x2) : new QuadraticEquationResult(x2, x1);
        }

        public override string ToString()
        {
            string message = A > 0 ? $"{A}x^2" : $"- {A * -1}x^2";

            if (B != 0)
                message += B > 0 ? $" + {B}x" : $" - {B * -1}x";

            if (C != 0)
                message += C > 0 ? $" + {C}" : $" - {C * -1}";

            return message += " = 0";
        }

        private double CalcOnlyRoot() => (B * -1) / (2 * A);

        private double CalcX1(double delta) => ((B * -1) - Math.Sqrt(delta)) / (2 * A);
        private double CalcX2(double delta) => ((B * -1) + Math.Sqrt(delta)) / (2 * A);
    }
}