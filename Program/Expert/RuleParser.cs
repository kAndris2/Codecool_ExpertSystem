using System;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    class RuleParser : XMLParser
    {
        public RuleRepository getRuleRepository() { return new RuleRepository(); }

        public override void loadXmlDocument(string xmlPath)
        {

        }
    }
}
