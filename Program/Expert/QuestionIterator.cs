using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    class QuestionIterator : IEnumerator<Question>
    {
        Question[] questions;
        int position = -1;

        public QuestionIterator(Question[] questions)
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
            return (position < questions.Length);
        }

        void IEnumerator.Reset()
        {
            position = -1;
        }
    }
}
