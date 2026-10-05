using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism_overridex1
{
    internal class school : college
    {
        public override void Details()
        {
            Console.WriteLine("this is school");  
        }

    }
}
