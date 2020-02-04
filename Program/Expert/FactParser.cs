using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Expert
{
    class FactParser : XMLParser
    {
        public FactRepository getFactRepository() { return new FactRepository(); }

        public override void loadXmlDocument(string xmlPath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlPath);
            foreach (XmlNode xmlNode in xmlDoc.DocumentElement)
            {
                string tempID = xmlNode.Attributes["id"].Value;
                string tempDescription = xmlNode.ChildNodes[0].Attributes["value"].Value;

                Fact fact = new Fact(tempID, tempDescription);
                foreach (XmlNode item in xmlNode.ChildNodes[1])
                {
                    tempID = item.Attributes["id"].Value;
                    bool tempValue = item.InnerText.Equals("true");
                    fact.setFactValueById(tempID, tempValue);
                }
            }
        }
    }
}
