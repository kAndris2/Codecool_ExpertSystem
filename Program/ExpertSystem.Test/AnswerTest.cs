using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Expert;

namespace ExpertSystem.Test
{
    public class AnswerTest
    {
        [Fact]
        public void AddValue_Work()
        {
            Value value = new SingleValue(new string[] { "test" }, true);
            Answer answer = new Answer();
            answer.addValue(value );

            Assert.True(answer.GetValues().Count == 1);
            Assert.Contains<Value>(value, answer.GetValues());
        }
        [Fact]
        public void EvaluateAnswerByInput_True()
        {
            Value value = new SingleValue(new string[] { "test" }, true);
            Answer answer = new Answer();
            answer.addValue(value);

            
            Assert.True(answer.evaluateAnswerByInput("test"));
        }
        [Fact]
        public void EvaluateAnswerByInput_False()
        {
            Value value = new SingleValue(new string[] { "test" }, false);
            Answer answer = new Answer();
            answer.addValue(value);


            Assert.False(answer.evaluateAnswerByInput("test"));
        }
        [Fact]
        public void EvaluateAnswerByInput_Fail()
        {
            Value value = new SingleValue(new string[] { "test" }, true);
            Answer answer = new Answer();
            answer.addValue(value);


            Assert.Throws<ArgumentException>(() => answer.evaluateAnswerByInput("!test"));
        }
    }
}
