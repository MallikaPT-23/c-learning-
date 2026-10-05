using System;
using System.Collections.Generic;
using System.Text;

namespace abstraction_ex1
{
    internal class Flight : Transport
    {
        public override void travel()
        {
            Console.WriteLine("the transport type is Air transport");

        }

    }
}
