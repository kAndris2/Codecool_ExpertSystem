using System;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    class FactParser : XMLParser
    {
        FactRepository repo;

        public FactParser()
        {
            repo = getFactRepository();
        }

        public FactRepository getFactRepository() { return new FactRepository(); }

        public override void loadXmlDocument(string xmlPath)
        {

        }
    }
}
