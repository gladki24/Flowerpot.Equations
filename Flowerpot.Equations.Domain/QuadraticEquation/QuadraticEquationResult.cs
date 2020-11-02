using System;
using System.Collections.Generic;
using System.Text;

namespace Flowerpot.Equations.Domain.QuadraticEquation
{
    public class QuadraticEquationResult
    {
        public double? FirstRoot { get; }
        public double? SecondRoot { get; }

        public double? OnlyRoot
        {
            get => HasOneRoot() ? FirstRoot : null;
        }

        public QuadraticEquationResult()
        {
        }

        public QuadraticEquationResult(double onlyRoot)
        {
            FirstRoot = onlyRoot;
        }

        public QuadraticEquationResult(double firstRoot, double secondRoot)
        {
            FirstRoot = firstRoot;
            SecondRoot = secondRoot;
        }

        public bool HasNoRoots() => FirstRoot is null && SecondRoot is null;

        public bool HasOneRoot() => !(FirstRoot is null) && SecondRoot is null;
        public bool HasTwoRoots() => !(FirstRoot is null) && !(SecondRoot is null);
    }
}