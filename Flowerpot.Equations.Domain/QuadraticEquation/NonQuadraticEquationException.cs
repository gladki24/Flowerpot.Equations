using System;

namespace Flowerpot.Equations.Domain
{
    public class NonQuadraticEquationException : Exception
    {
        public NonQuadraticEquationException() : base("Non quadratic equation") { }
    }
}
