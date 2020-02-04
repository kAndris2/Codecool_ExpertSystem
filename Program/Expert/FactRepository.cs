using System;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    class FactRepository
    {
        private Fact fact;

        public void addFact(Fact fact)
        {
            this.fact = fact;
        }

        //public IEnumerator<Fact> getEnumerator() { return new FactIterator(fact.evals); }
    }
}
