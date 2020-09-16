using csharp9.TargetTyped;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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
            var c1 = new Cat("Chester");
            Cat c = new("Chester"); // C# 9.0
        }

        [Fact]
        public void SharedBasedType()
        {
            Cat c;
            Dog d = new("mountain berny");
            // Animal a = c ?? d; // This feature as not been implemented yet
        }

        [Fact]
        public void Nullable()
        {
            bool booleanExpression = false;
            int? someInt = booleanExpression ? 0 : null;
        }
    }
}
