using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class DishWasher : AWasher, IWasher
    {
        public override void AHello()
        {
            throw new NotImplementedException();
        }

        public void Wash()
        {
            Console.WriteLine("Wash like a dishwasher");
        }
    }
}
