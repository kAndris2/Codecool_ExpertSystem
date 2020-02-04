using System;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    class RuleParser : XMLParser
    {
        RuleRepository ruleRepository;
        public RuleParser()
        {
            this.ruleRepository = new RuleRepository();
        }
        public RuleRepository getRuleRepository() 
        {
            return this.ruleRepository;
        }

        public override void loadXmlDocument(string xmlPath)
        {

        }
    }
}
