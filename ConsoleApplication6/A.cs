using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    public class A
    {
        public void S1()
        {
            throw new System.NotImplementedException();

            Console.WriteLine("A::S1");
            V1(); 

        }

        protected void V1()
        {
            throw new System.NotImplementedException();

            Console.WriteLine("A::v1");
            S3();
        }

        public void S2()
        {
            throw new System.NotImplementedException();

            Console.WriteLine("A::S2");
            S1();
        }

        private void S3()
        {
            throw new System.NotImplementedException();

            Console.WriteLine("A::S3");

        }
    }
}