using System;
using System.Xml;

namespace Expert
{
    class Program
    {
        static void Main(string[] args)
        {
            ESProvider esp = new ESProvider(new FactParser(), new RuleParser());

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("rules.xml");
            foreach (XmlNode xmlNode in xmlDoc.DocumentElement)
                //Console.WriteLine(xmlNode.Attributes["id"].Value);
                Console.WriteLine(xmlNode.Attributes["id"]);
        }
    }
}
