using csharp9.TargetTyped;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace csharp9.Tests.Unit.TargetType
{
    public class TargetTypeTests
    {
        [Fact]
        public void NewTargetType()
        {
            Cat c = new("Chester"); // C# 9.0
        }
    }
}
