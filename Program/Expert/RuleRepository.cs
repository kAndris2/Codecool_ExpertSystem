using System;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    class RuleRepository
    {
        QuestionIterator questionIterator ;
        public List<Question> questions = new List<Question>();
        Question question;

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
