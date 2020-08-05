using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp9.InitProp
{
    public class OrderService
    {
        public void Process()
        {
            var o = new Order
            {
                Number = 1,
            };
           
            //o.Number = 2; // Error
        }
    }
}
