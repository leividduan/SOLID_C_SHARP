using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesSealed
{
    class X
    {
        protected virtual void F()
        {
            Console.WriteLine("X.F");
        }
        protected virtual void F2()
        {
            Console.WriteLine("X.F2");
        }
    }
}
