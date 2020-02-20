using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiDemo
{
    public class Test : ITest
    {
        public int Add(int a, int b)
        {
            return a + b;

        }
    }

    public class Test2 : ITest
    {
        public int Add(int a, int b)
        {
            return a * b;

        }
    }
}
