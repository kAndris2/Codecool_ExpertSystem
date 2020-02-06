using System;
using System.Xml;
using System.IO;

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
            catch (ArgumentException e) { ManageEx(e.Message); }
            catch (FileNotFoundException e) { ManageEx(e.Message); }
        }

        public static void ManageEx(string message)
        {
            Console.WriteLine("[ERROR]: " + message);
        }
    }
}
