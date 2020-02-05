using System;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    class Answer
    {
        List<Value> values = new List<Value>();
        Value value;

        public Answer()
        {
            
        }

        public bool evaluateAnswerByInput(string input)
        {
            return true;
        }

        public void addValue(Value value)
        {
            values.Add(value);
        }
        
    }
}
