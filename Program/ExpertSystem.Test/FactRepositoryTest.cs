using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Expert;

namespace ExpertSystem.Test
{
    public class FactRepositoryTest
    {
        [Fact]
        public void AddQuestion_Work()
        {
            Fact fact = new Fact("id", "test description");

            FactRepository factRepository = new FactRepository();
            factRepository.addFact(fact);
            Assert.True(factRepository.GetFacts().Count == 1);
            Assert.Contains<Fact>(fact, factRepository.GetFacts());
        }
    }
}
