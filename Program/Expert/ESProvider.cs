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
            
            ruleParser.loadXmlDocument("rules.xml");
            IEnumerator<Question> enumerator = ruleParser.getRuleRepository().getEnumerator();
            
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.getQuestion());
                bool userInput = enumerator.Current.getEvaluatedAnswer(Console.ReadLine());
                
                if (userInput)
                {
                    userAnswers.Add(enumerator.Current.getId(), userInput);
                    
                }
                else
                {
                    throw new ArgumentException("Invalid input.");
                }
                

            }
        }

        public bool getAnswerByQuestion()
        {
            return true;
        }

        public string evaluate()
        {
            return null;
        }
    }
}
