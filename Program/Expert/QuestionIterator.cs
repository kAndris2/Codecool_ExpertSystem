using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    public class QuestionIterator : IEnumerator<Question>
    {
        List<Question> questions;
        int position = -1;

        public QuestionIterator(List<Question> questions)
        {
            this.questions = questions;
        }

        //Question IEnumerator<Question>.Current => throw new NotImplementedException();

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Question Current
        {
            get
            {
                try
                {
                    return questions[position];
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
            return (position < questions.Count);
        }

        void IEnumerator.Reset()
        {
            position = -1;
        }
    }
}
