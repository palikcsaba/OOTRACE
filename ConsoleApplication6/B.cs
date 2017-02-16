using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    public class B : A
    {
        protected void S4()
        {
            throw new System.NotImplementedException();
            Console.WriteLine("B::S4");
            V1();
        }

        public void S5()
        {
            throw new System.NotImplementedException();
            Console.WriteLine("B::S5");
            S3();
        }

        protected void S3()
        {
            throw new System.NotImplementedException();
            Console.WriteLine("B::S3");

        }

        public void V2()
        {
            throw new System.NotImplementedException();
            Console.WriteLine("B::V2");
            V1();
        }

        protected void V1()
        {
            throw new System.NotImplementedException();
            Console.WriteLine("B::V1");
            S5();
        }
    }
}