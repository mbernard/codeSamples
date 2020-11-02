
using Xunit;

namespace csharp9.Tests.Unit.NativeSizedInt
{
    public class NativeSizedIntTests
    {
        [Fact]
        public void GivenGiven_WhenWhen_ThenThen()
        {
            // Given
            nint i = 2;
            var p = nint.Parse("123");
            var p2 = nint.Parse("3");


            // When
            var t = p * i;
            //var t2 = p * p2; This is not allowed

            // Then
            Assert.Equal(246, t);
        }

    }
}
