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
                string tempDescription = xmlNode.ChildNodes[0].InnerText;
                List<string> tempValue =new List<string>();
                tempValue.Add(xmlNode.ChildNodes[1].ChildNodes[0].ChildNodes[0].Name);
                string[] answers = new string[tempValue.Count];
                
                
                for (int i = 0; i < tempValue.Count; i++)
                {
                    answers[i] = tempValue[i];
                    

                }
                ruleRepository.addQuestion(new Question(tempID, tempDescription, new Answer(answers)));
                
            }
        }
    }
}
