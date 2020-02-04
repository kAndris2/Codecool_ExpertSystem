﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    class FactIterator : IEnumerator<Fact>
    {
        Fact[] facts;
        int position = -1;

        public FactIterator(Fact[] facts)
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
            return (position < facts.Length);
        }

        void IEnumerator.Reset()
        {
            position = -1;
        }
    }
}
