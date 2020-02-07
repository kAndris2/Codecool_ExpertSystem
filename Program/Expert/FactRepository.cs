using System;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    public class FactRepository
    {
        List<Fact> Facts = new List<Fact>();

        public void addFact(Fact fact)
        {
            Facts.Add(fact);
        }

        public IEnumerator<Fact> getEnumerator() 
        {
            return new FactIterator(Facts); 
        }
        public List<Fact> GetFacts()
        {
            return Facts;
        }
    }
}
