using System;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    class Question
    {
        string question { get; set; }
        string id { get; set; }
        private Answer answer;

        public Question(string id, string question, Answer answer)
        {
            this.id = id;
            this.question = question;
            this.answer = answer;
        }

        public string getId() { return id; }
        public string getQuestion() { return question; }
        public Answer getAnswer() { return answer; }

        public bool getEvaluatedAnswer(string input)
        {
            return true;
        }
    }
}
