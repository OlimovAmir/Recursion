using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Recursion
    {
        static void Foo(int i)
        {
            Console.WriteLine(i);
            if (i >=4)
            {
                return;
            }
            ++i;
            Foo(i);
        }
        static void Main(string[] args)
        {
            Foo(0);
        }
    }
}
