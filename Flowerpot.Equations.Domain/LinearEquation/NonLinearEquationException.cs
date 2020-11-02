using System;

namespace Flowerpot.Equations.Domain
{
    public class NonLinearEquationException : Exception
    {
        public NonLinearEquationException() : base("Non linear equation")
        {}
    }
}
