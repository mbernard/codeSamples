using csharp9.Records;
using System;
using Xunit;

namespace csharp9.Tests.Unit.Records
{
    public class RecordTests
    {
        [Fact]
        public void InitOnlyByDefault()
        {
            var c = new Chicken { Name = "test" };
            Assert.Equal("test", c.Name);

            // setting a value is not allowed
            //c.Name = "t";
        }

        [Fact]
        public void RecordsWith()
        {
            var c = new Chicken { Name = "test" };
            var c2 = c with { Name = "myNewName" };

            Assert.Equal("myNewName", c2.Name);
            Assert.NotEqual(c, c2);
        }


        [Fact]
        public void StructuralEquality()
        { 
            var c = new Chicken { Name = "test" };
            var c2 = new Chicken { Name = "test" };

            Assert.False(c == c2);
            Assert.Equal(c, c2);
        }

        [Fact]
        public void Deconstructor()
        {
            var now = DateTime.UtcNow;
            var deconstructMe = new Deconstructable(42, "My super name", now);
            var(x, y, z) = deconstructMe;

            Assert.Equal(42, x);
            Assert.Equal("My super name", y);
            Assert.Equal(now, z);
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

        // This is not supported yet
        //public void ThisIsADummyMethod<T>(T t) where T : record
        //{
        //}
    }
}