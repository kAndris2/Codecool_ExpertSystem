using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    class FactIterator : IEnumerable<Fact>
    {
        IEnumerator<Fact> IEnumerable<Fact>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
