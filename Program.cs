using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        public static T Max<T>(T x, T y) where T:IComparable
        {
            if (x.CompareTo(y) > 0)
                return x;
            else
                return y;
        }
        static void Main(string[] args)
        {
            //MyMath<int> obj = new MyMath<int>();
            //var res = obj.Max(10, 20);
            var res = Max<int>(10, 20);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
