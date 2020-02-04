using System;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    class RuleRepository
    {
        Dictionary<string, Question> questions = new Dictionary<string, Question>();
        QuestionIterator Iquestion;
        private Question question;
        public RuleRepository()
        {
            Iquestion = new QuestionIterator();
        }

        public void addQuestion(Question question)
        {
            this.question = question;
        }

        /*
        public Iterator<Question> getIterator()
        {
            return null;
        }
        */
    }
}
