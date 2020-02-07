using System;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    public class Answer
    {
        List<Value> values = new List<Value>();

        public bool evaluateAnswerByInput(string input)
        {
            for (int i = 0; i < values.Count; i++)
            {
                string[] temp = values[i].getInputPattern();
                if (Array.Exists(temp, element => element == input))
                    return values[i].getSelectionType();
            }
            throw new ArgumentException("Invalid input");
        }

        public void addValue(Value value)
        {
            values.Add(value);
        }
        public List<Value> GetValues()
        {
            return values;
        }
    }
}
