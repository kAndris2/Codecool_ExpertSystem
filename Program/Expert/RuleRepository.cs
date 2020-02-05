using System;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    class RuleRepository
    {
        public List<Question> questions = new List<Question>();

        public void addQuestion(Question question)
        {
            questions.Add(question);
        }

        public IEnumerator<Question> getEnumerator() 
        { 
            return new QuestionIterator(questions); 
        }
    }
}
