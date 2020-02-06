using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    public class FactIterator : IEnumerator<Fact>
    {
        List<Fact> facts { get; set; } = new List<Fact>();
        int position = -1;

        public FactIterator(List<Fact> facts)
        {
            this.facts = facts;
        }

        //Fact IEnumerator<Fact>.Current => throw new NotImplementedException();

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Fact Current
        {
            get
            {
                try
                {
                    return facts[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }

        bool IEnumerator.MoveNext()
        {
            position++;
            return (position < facts.Count);
        }

        void IEnumerator.Reset()
        {
            position = -1;
        }
    }
}
