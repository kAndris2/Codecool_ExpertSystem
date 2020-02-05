using System;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    class ESProvider
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
            factParser.loadXmlDocument("facts.xml");
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
            
            
            
            
            
            int checkCounter;
            foreach (var fact in factParser.Facts)
            {
                
                checkCounter = 0;
                foreach (var answer in fact.evals)
                {
                    
                    if (getAnswerByQuestion(answer.Key).Equals(fact.evals[answer.Key]))
                    {
                        checkCounter++;
                    }
                }
                if (checkCounter == userAnswers.Count)
                {
                    return fact.getDescription();
                }
            }
            return null;
        }
    }
}
