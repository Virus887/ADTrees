using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8.Nodes
{
    interface IDurationProvider
    {
        int GetDuration(int c1, int c2);
    }

    class ORMinDuration : IDurationProvider
    {
        public int GetDuration(int t1, int t2)
        {
            return Math.Min(t1, t2);
        }
    }

    class ANDMinDuration : IDurationProvider
    {
        public int GetDuration(int t1, int t2)
        {
            return t1 + t2;
        }
    }

    class ORMaxDuration : IDurationProvider
    {
        public int GetDuration(int t1, int t2)
        {
            return Math.Max(t1, t2);
        }
    }
}
