using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Recursion
    {
        static void Foo()
        {
            Console.WriteLine("Foo");
            Foo();
        }
        static void Main(string[] args)
        {
            Foo();
        }
    }
}
