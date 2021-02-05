using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesSealed
{
    class Z : Y
    {
        protected override void F()
        {
            Console.WriteLine("Z.F");
        }
        protected override void F2()
        {
            Console.WriteLine("Z.F2");
        }
    }
}
