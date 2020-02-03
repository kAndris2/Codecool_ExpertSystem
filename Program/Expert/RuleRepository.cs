using System;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    class RuleRepository
    {
        Dictionary<string, string> questions = new Dictionary<string, string>();
        QuestionIterator Iquestion;

        public RuleRepository()
        {
            Iquestion = new QuestionIterator();
        }

        public void addQuestion(Question question)
        {

        }

        /*
        public Iterator<Question> getIterator()
        {
            return null;
        }
        */
    }
}
