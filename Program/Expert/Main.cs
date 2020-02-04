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
            xmlDoc.Load("facts.xml");
            foreach (XmlNode xmlNode in xmlDoc.DocumentElement)
            {
                foreach(XmlNode item in xmlNode.ChildNodes[1])
                {
                    Console.WriteLine(item.InnerText);
                }

            }
        }
    }
}
