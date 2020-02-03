using System;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    class Answer
    {
        List<string> values = new List<string>();

        public Answer(string[] values)
        {
            for (int i = 0; i < values.Length; i++)
                this.values[i] = values[i];
        }

        public bool evaluateAnswerByInput(string input)
        {
            return true;
        }

        public void addValue()
        {

        }
    }
}
