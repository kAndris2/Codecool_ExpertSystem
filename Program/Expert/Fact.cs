using System;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    class Fact
    {
        string id { get; set; }
        string description { get; set; }
        Dictionary<string, bool> evals { get; set; } = new Dictionary<string, bool>();

        public Fact(string id, string description, Dictionary<string, bool> evals)
        {
            this.id = id;
            this.description = description;
            this.evals = evals;
        }

        public HashSet<string> getIdSet()
        {
            return null;
        }

        public void setFactValueById(string id, bool value)
        {

        }

        public bool getValueById(string id) { return evals[id]; }

        public string getDescription() { return description; }
    }
}
