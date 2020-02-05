using System;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    class SingleValue : Value
    {
        string[] param { get; set; } = new string[1];

        
        bool selectionType { get; set; }

        public SingleValue(string[] param, bool selectionType)
        {
            this.param[0] = param[0];
            this.selectionType = selectionType;
        }

        public override string[] getInputPattern()
        {
            return param;
        }

        public override bool getSelectionType()
        {
            return selectionType;
        }
    }
}
