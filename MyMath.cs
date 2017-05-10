using System;

namespace ConsoleApplication2
{
    public class MyMath<T> where T: IComparable
    {
        public T Max(T x, T y)
        {
            if (x.CompareTo(y) > 0)
                return x;
            else
                return y;
        }

    }
}