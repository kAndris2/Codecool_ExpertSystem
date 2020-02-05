using System;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    class MultipleValue : Value
    {
        string[] param { get; set; }
        bool selectionType { get; set; }

        public MultipleValue(string[] param, bool selectionType)
        {
            this.param = param;
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
