using System;
using System.Xml;

namespace Expert
{
    class Program
    {
        static void Main(string[] args)
        {
            ESProvider esp = null;
            try
            {
                esp = new ESProvider(new FactParser(), new RuleParser());
            }
            catch (ArgumentException e) { Console.WriteLine("[ERROR]: ", e.Message); }
            esp.collectAnswers();
        }
    }
}
