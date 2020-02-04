using System;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    class MultipleValue : Value
    {
        List<string> param { get; set; } = new List<string>();
        bool selectionType { get; set; }

        public MultipleValue(List<string> param, bool selectionType)
        {
            this.param = param;
            this.selectionType = selectionType;
        }
    }
}
