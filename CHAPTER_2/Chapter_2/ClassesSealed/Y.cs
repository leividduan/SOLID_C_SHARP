﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesSealed
{
    class Y : X
    {
        sealed protected override void F()
        {
            Console.WriteLine("Y.F");
        }
        protected override void F2()
        {
            Console.WriteLine("Y.F2");
        }
    }
}
