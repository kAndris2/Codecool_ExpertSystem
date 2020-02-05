using System;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    class Answer
    {
        List<Value> values = new List<Value>();

        public bool evaluateAnswerByInput(string input)
        {
            for (int i = 0; i < values.Count; i++)
            {
                string[] temp = values[i].getInputPattern();
                if (Array.Exists(temp, element => element == input))
                    return true;
            }
            return false;
        }

        public void addValue(Value value)
        {
            values.Add(value);
        }
    }
}
