using System;
using System.Collections.Generic;
using System.Text;

namespace abstraction_ex1
{
    internal class Train : Transport
    {
        public override void travel()
        {
            Console.WriteLine("the transport type is Rail transport");
        }

    }
}
