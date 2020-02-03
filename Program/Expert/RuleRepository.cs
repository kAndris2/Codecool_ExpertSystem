using System;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    class RuleRepository
    {
        Dictionary<string, Question> questions = new Dictionary<string, Question>();
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
