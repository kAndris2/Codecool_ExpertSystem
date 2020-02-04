using System;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    class RuleRepository
    {
        List<Question> questions = new List<Question>();
        private Question question;

        public void addQuestion(Question question)
        {
            this.question = question;
        }

        public IEnumerator<Question> getEnumerator() { return new QuestionIterator(questions); }
    }
}
