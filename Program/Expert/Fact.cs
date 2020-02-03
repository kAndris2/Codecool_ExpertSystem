using System;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    class Fact
    {
        string id { get; set; }
        string description { get; set; }

        public Fact(string id, string description)
        {
            this.id = id;
            this.description = description;
        }

        public HashSet<string> getIdSet()
        {
            return null;
        }

        public void setFactValueById(string id, bool value)
        {

        }

        public bool getValueById(string id)
        {
            return true;
        }

        public string getDescription() { return description; }
    }
}
