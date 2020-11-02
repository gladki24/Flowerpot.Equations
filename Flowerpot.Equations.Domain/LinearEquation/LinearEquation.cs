using Flowerpot.Equations.Infrastructure;

namespace Flowerpot.Equations.Domain
{
    [Equation]
    public class LinearEquation
    {
        public double A { get; }
        public double B { get; }

        public LinearEquation(double a)
        {
            if (a == 0)
                throw new NonLinearEquationException();

            A = a;
            B = 0;
        }

        public LinearEquation(double a, double b)
        {
            if (a == 0)
                throw new NonLinearEquationException();

            A = a;
            B = b;
        }

        public double CalcResult()
        {
            return B / A * -1;
        }

        public override string ToString()
        {
            string message = A > 0 ? $"{A}x" : $"- {A * -1}x";

            if (B != 0)
            {
                message += B > 0 ? $" + {B}" : $" - {B * -1}";
            }

            return message += " = 0";
        }
    }
}
