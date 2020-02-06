using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Expert
{
    public class FactParser : XMLParser
    {
        FactRepository factRepository ;

        public FactParser()
        {
            factRepository = new FactRepository();
        }
        
        public FactRepository getFactRepository() 
        { 
            return factRepository;
        
        }

        public override void loadXmlDocument(string xmlPath)
        {
            if (!File.Exists(xmlPath))
                throw new FileNotFoundException($"File not found! ('{xmlPath}')");

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
                factRepository.addFact(fact);
            }
        }
    }
}
