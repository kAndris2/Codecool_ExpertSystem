using System;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    public class Fact
    {
        public string id { get; set; }
        string description { get; set; }
        public Dictionary<string, bool> evals { get; set; } = new Dictionary<string, bool>();
        private HashSet<string> factIDs = new HashSet<string>();

        public Fact(string id, string description)
        {
            this.id = id;
            this.description = description;
            factIDs.Add(id);
        }

        public void setFactValueById(string id, bool value) { evals.Add(id, value); }

        public HashSet<string> getIdSet() { return factIDs; }

        public bool getValueById(string id) { return evals[id]; }

        public string getDescription() { return description; }
    }
}
