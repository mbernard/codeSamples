using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp9.ExtendingPartialMethods
{
    partial class Parser
    {
        internal partial bool TryParse(string s, out int i);
    }

    partial class Parser
    {
        internal partial bool TryParse(string s, out int i)
        {
            i = 0;
            return true;
        }
    }
}
