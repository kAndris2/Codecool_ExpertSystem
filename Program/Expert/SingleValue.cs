using System;
using System.Collections.Generic;
using System.Text;

namespace Expert
{
    class SingleValue : Value
    {
        string param { get; set; }
        bool selectionType { get; set; }

        public SingleValue(string param, bool selectionType)
        {
            this.param = param;
            this.selectionType = selectionType;
        }
    }
}
