using System;
using System.Xml;

namespace Expert
{
    class Program
    {
        static void Main(string[] args)
        {
            ESProvider esp = new ESProvider(new FactParser(), new RuleParser());
            try
            {
                esp.collectAnswers();
                string winner = esp.evaluate();
                Console.WriteLine($"Winner:  {winner}");
            }
            catch (ArgumentException e) { Console.WriteLine("[ERROR]: "+ e.Message); }
           
        }
    }
}
