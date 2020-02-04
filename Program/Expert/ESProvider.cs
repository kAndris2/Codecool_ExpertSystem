using System;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    class ESProvider
    {
        FactParser factParser;
        RuleParser ruleParser;

        public ESProvider(FactParser factParser, RuleParser ruleParser)
        {
            this.factParser = factParser;
            this.ruleParser = ruleParser;
        }

        public void collectAnswers()
        {
            //Question q1 = new Question("1", "q1?", new Answer(new string[] { "ws","sdf"}));
            //Question q2 = new Question("2", "q2?", new Answer(new string[] { "ws", "sdf" }));
            ////ruleParser.getRuleRepository().addQuestion(q1);
            ////ruleParser.getRuleRepository().addQuestion(q2);
            //ruleParser.getRuleRepository().questions.Add(q1);
            //ruleParser.getRuleRepository().questions.Add(q2);
            ruleParser.loadXmlDocument("rules.xml");
            IEnumerator<Question> enumerator = ruleParser.getRuleRepository().getEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.getQuestion());
                Console.ReadLine();


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
