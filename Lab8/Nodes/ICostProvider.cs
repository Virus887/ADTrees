using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8.Nodes
{
    interface ICostProvider
    {
        int GetCost(int c1, int c2);
    }

    class ORMinCost : ICostProvider
    {
        public int GetCost(int c1, int c2)
        {
            return Math.Min(c1, c2);
        }
    }

    class ANDMinCost : ICostProvider
    {
        public int GetCost(int c1, int c2)
        {
            return c1+c2;
        }
    }

    class ORMaxCost : ICostProvider
    {
        public int GetCost(int c1, int c2)
        {
            return Math.Max(c1, c2);
        }
    }
}

