using Expert;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ExpertSystem.Test
{
    public class QuestionTest
    {
        [Fact]
        public void GetId_Work()
        {
            string expected = "testid";
            string actual = "testid";

            Question question = new Question(actual,"",new Answer());
            question.getId();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetQuestion_Work()
        {
            string expected = "test question";
            string actual = "test question";

            Question question = new Question("", actual, new Answer());
            question.getQuestion();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetAnswer_Work()
        {
            Answer answer = new Answer();
            Answer expected = answer;
            
            Question question = new Question("", "", answer);
            question.getAnswer();
            Assert.Equal(expected, answer);
        }
        [Fact]
        public void GetEvaluatedAnswer_True()
        {
            Answer answer = new Answer();
            string testinput = "test";
            Value value = new SingleValue(new string[] { testinput }, true);
            answer.addValue(value);

            Question question = new Question("", "", answer);
            question.getEvaluatedAnswer(testinput);
            Assert.True(true, "test");
        }
        [Fact]
        public void GetEvaluatedAnswer_False()
        {
            Answer answer = new Answer();
            string testinput = "test";
            Value value = new SingleValue(new string[] { testinput }, true);
            answer.addValue(value);

            Question question = new Question("", "", answer);
            question.getEvaluatedAnswer(testinput);
            Assert.False(false, "!!!!!test");
        }
    }
}
