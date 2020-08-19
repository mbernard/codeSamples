using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp9.NullChecking
{
    class NullCheckingService
    {
        public void Before(string name)
        {
            if (name is null)
                throw new ArgumentNullException();
        }

        // Not supported in VS yet
        //public void Now(string name!)
        //{
        //}
    }
}
