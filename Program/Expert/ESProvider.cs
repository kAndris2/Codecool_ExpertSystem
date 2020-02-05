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
                
                
                userAnswers.Add(enumerator.Current.getId(), userInput);
                 
                

            }
        }

        public bool getAnswerByQuestion()
        {
            return true;
        }

        public string evaluate()
        {

            foreach (var item in userAnswers)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            
            return null;
        }
    }
}
