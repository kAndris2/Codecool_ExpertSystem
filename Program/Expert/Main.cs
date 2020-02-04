using System;
using System.Xml;

namespace Expert
{
    class Program
    {
        static void Main(string[] args)
        {
            ESProvider esp = new ESProvider(new FactParser(), new RuleParser());
            
            Console.WriteLine("---------------");
            XmlDocument xmlDoc = new XmlDocument();
            esp.collectAnswers();
            //xmlDoc.Load("rules.xml");
            ////foreach (XmlNode xmlNode in xmlDoc.DocumentElement)
            ////{
            ////    //Console.WriteLine(xmlNode.Attributes["id"].Value); //I
            ////    //Console.WriteLine(xmlNode.ChildNodes[0].InnerText); //Q
            ////    //Console.WriteLine(xmlNode.ChildNodes[1].ChildNodes[0].ChildNodes[0].Name); //A
            ////    Console.WriteLine(xmlNode.ChildNodes[0].InnerText);
            //xmlDoc.Load("facts.xml");
            //foreach (XmlNode xmlNode in xmlDoc.DocumentElement)
            //{
            //    foreach(XmlNode item in xmlNode.ChildNodes[1])
            //    {
            //        Console.WriteLine(item.InnerText);
            //    }

            //}
        }
    }
}
