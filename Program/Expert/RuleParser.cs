using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

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
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlPath);
            foreach (XmlNode xmlNode in xmlDoc.DocumentElement)
            {
                string tempID = xmlNode.Attributes["id"].Value;
                string tempQuestion = xmlNode.ChildNodes[0].InnerText;
                List<string> tempValue =new List<string>();
                
                Answer answer = new Answer();
                foreach (XmlNode item in xmlNode.ChildNodes[1])
                {
                    
                    string[] selectionString1 = (item.ChildNodes[0].Attributes["value"].Value).Split(",");
                    string selectionType1 = item.Attributes["value"].Value;
                    Value value;
                    if (selectionString1.Length > 0)
                    {
                        value = new MultipleValue(selectionString1,selectionType1.Equals("true"));
                    }
                    else
                    {
                        value = new SingleValue(selectionString1, selectionType1.Equals("true"));
                    }

                    answer.addValue(value);
                    
                   
                }

                tempValue.Add(xmlNode.ChildNodes[1].ChildNodes[0].ChildNodes[0].Name);
                
                ruleRepository.addQuestion(new Question(tempID, tempQuestion, answer));
                
            }
        }
    }
}
