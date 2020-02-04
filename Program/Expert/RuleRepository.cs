using System;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    class RuleRepository
    {
        Dictionary<string, Question> questions = new Dictionary<string, Question>();
        private Question question;

        public void addQuestion(Question question)
        {
            this.question = question;
        }

        public IEnumerator<Question> getEnumerator()
        {
            return new QuestionIterator();
        }
    }
}
