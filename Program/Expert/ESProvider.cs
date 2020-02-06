using System;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    public class ESProvider
    {
        FactParser factParser;
        RuleParser ruleParser;
        Dictionary<string, bool> userAnswers = new Dictionary<string, bool>();

        public ESProvider(FactParser factParser, RuleParser ruleParser)
        {
            this.factParser = factParser;
            this.ruleParser = ruleParser;
        }

        public void collectAnswers()
        {
            
            ruleParser.loadXmlDocument("rules.xml");
            IEnumerator<Question> enumerator = ruleParser.getRuleRepository().getEnumerator();
            
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.getQuestion());
                bool userInput = enumerator.Current.getEvaluatedAnswer(Console.ReadLine());
                
                
                userAnswers.Add(enumerator.Current.getId(), userInput);
                 
            }
        }

        public bool getAnswerByQuestion(string questionId)
        {
            
            return userAnswers[questionId];
        }

        public string evaluate()
        {


            factParser.loadXmlDocument("facts.xml");
            IEnumerator<Fact> enumerator = factParser.getFactRepository().getEnumerator();
            
            int checkCounter;
            while (enumerator.MoveNext())
            {
                
                checkCounter = 0;
                foreach (var answer in enumerator.Current.evals)
                {
                    
                    if (getAnswerByQuestion(answer.Key).Equals(enumerator.Current.evals[answer.Key]))
                    {
                        checkCounter++;
                    }
                }
                if (checkCounter == userAnswers.Count)
                {
                    return enumerator.Current.getDescription();
                }
            }
            return "There's no exact match.";
        }
    }
}
