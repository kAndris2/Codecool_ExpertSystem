using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expert;
using Xunit;

namespace ExpertSystem.Test
{
    public class RuleRepositoryTest
    {
        [Fact]
        public void AddQuestion_Work()
        {
            Question question = new Question ("id", "test question", new Answer() );

            RuleRepository ruleRepository = new RuleRepository();
            ruleRepository.addQuestion(question);
            Assert.True(ruleRepository.GetQuestions().Count == 1);
            Assert.Contains<Question>(question, ruleRepository.GetQuestions());
        }

    }
}
