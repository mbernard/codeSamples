using Xunit;

namespace csharp9.Tests.Unit.ImprovedPatternMatching
{
    public class ImprovedPatternMatchingTests
    {
        [Theory]
        [InlineData("string")]
        [InlineData(0)]
        public void NotKeyword(object s)
        {
            if (s is not string) { }

            // is way more easier to read than
            if (!(s is string)) { }
        }

        public record Person(int? Weight);

        [Fact]
        public void ImprovedPatternMatching()
        {
            var p = new Person(0);
            var a = p.Weight switch
            {
                < 150 => "light",
                >= 150 and < 200 => "normal",
                not null => "unknown",
                null => "error",
            };
        }

    }
}