using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using NUnit.Framework;

namespace Flowerpot.Equations.Domain.UnitTests
{
    public class EquationsTests
    {
        [SetUp]
        public void Setup()
        {

        }

        // [Test]
        public void EquationClassShouldHasEquationAttribute()
        {
            var types = GetDomainTypes();

            var equationTypes = types
                .Where(
                    type => 
                        type.FullName.Contains("Equation"));

            var equationTypesWithAttribute = types
                .Where(
                    type =>
                        type.IsClass && type.FullName.Contains("Equation"));

            Assert.Equals(equationTypes.Count(), equationTypesWithAttribute.Count());
        }

        private IEnumerable<Type> GetDomainTypes()
        {
            // TODO Fix domainNamespace ("Domain" != "Flowerpot.Equations.Domain")
            string domainNamespace = nameof(Flowerpot.Equations.Domain);

            var domainTypes = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(type => type.Namespace == domainNamespace);

            return domainTypes;
        }
    }
}
