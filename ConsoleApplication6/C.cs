﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    public class C : B
    {
        public void S6()
        {
            throw new System.NotImplementedException();

            Console.WriteLine("C::S6");
            V1();
        }

        public void S7()
        {
            throw new System.NotImplementedException();

            Console.WriteLine("C::S7");
            V2();
        }
    }
}