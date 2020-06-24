using System;
using System.Collections.Generic;
using System.Text;
using Task;

namespace Lab8.EvaluateVisitors
{
    class EvaluateCostVisitor : IEvaluateVisitor<int>
    {
        public int GetValue(IADTreeNode node, IEvaluateVisitor<int> v, ADTreeContext context)
        {
            if (node.Left == null && node.Right == null) return node.Cost;
            return node.CostProvider.GetCost(v.GetValue(node.Left, v, context), v.GetValue(node.Right, v, context)) + node.Cost;
        }
    }
}

