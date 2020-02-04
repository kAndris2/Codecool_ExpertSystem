using System;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    class Answer
    {
        List<string> values = new List<string>();
        private Value value;
        public Answer(string[] values)
        {
            for (int i = 0; i < values.Length; i++)
                this.values.Add(values[i]);
        }

        public bool evaluateAnswerByInput(string input)
        {
            return true;
        }

        public void addValue(Value value)
        {
            this.value = value;
        }
    }
}
