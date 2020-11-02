using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using csharp9.Records;

namespace csharp9.CovariantReturns
{
    public class CovariantReturnsSample
    {
        public void Sample()
        {
            //var t = new Tiger();
            //Meat m = t.GetFood();
        }

        public abstract class AnimalFood
        {

        }

        public class Meat : AnimalFood
        {

        }

        public abstract class Animal
        {
            public abstract AnimalFood GetFood();
        }

        //public class Tiger : Animal
        //{
        //    // Not yet available
        //    public override Meat GetFood() => new Meat();
        //}
    }
}
