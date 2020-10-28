using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        delegate int sum(int x, int y);
        static void Main(string[] args)
        {
            sum s = delegate (int x, int y)
            {
                return x + y;
            };
            sum ss = (x, y) => x + y;
            Console.WriteLine(s(1, 2));
            Console.WriteLine(ss(1, 2));
            Console.ReadKey();
        }
    }
}
