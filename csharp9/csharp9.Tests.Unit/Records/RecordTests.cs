using csharp9.Records;
using Xunit;

namespace csharp9.Tests.Unit.Records
{
    public class RecordTests
    {
        [Fact]
        public void InitOnlyByDefault()
        {
            var r = new Chicken { Name = "test" };

            //r.Name = "t";
            //var m = new Milk { Calories = 1, FatPercentage = 3.25 };
            //m.Calories = 2;
        }

        [Fact]
        public void Deconstructor()
        {
            var m = new Milk(1, 3.25);
            var (x, y) = m;

            Assert.Equal(1, x);
            Assert.Equal(3.25, y);
        }

        [Fact]
        public void DeconstructAsBaseType()
        {
            Food f = new Milk(1, 3.25);
            // This is not valid
            //var (x) = f;

            // This work though
            f.Deconstruct(out var x);

            Assert.Equal(1, x);
        }

        [Fact]
        public void PropertyNameInheritence()
        {
            var m = new Milk(1, 3.25);

            Assert.Equal(1, m.C);
            Assert.Equal(1, m.Calories);
        }
    }
}