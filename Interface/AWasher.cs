using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    abstract class AWasher
    {
        public string Name { get; set; }



        public void Hello()
        {
            Console.WriteLine("Hello");
        }

        public abstract void AHello();
    }
}
