using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    class QuestionIterator : IEnumerable<Question>
    {
        IEnumerator<Question> IEnumerable<Question>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
