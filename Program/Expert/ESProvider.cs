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
