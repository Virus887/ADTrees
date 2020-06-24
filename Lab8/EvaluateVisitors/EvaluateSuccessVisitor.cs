using System;
using System.Collections.Generic;
using System.Text;
using Task;

namespace Lab8.EvaluateVisitors
{
    class EvaluateSuccessVisitor : IEvaluateVisitor<bool>
    {
        public bool GetValue(IADTreeNode node, IEvaluateVisitor<bool> v, ADTreeContext context)
        {
            Random rnd = new Random();

            if (node.Left == null && node.Right == null)
            {
                bool? nb = context.GetNodeOutcome(node.Name);
                return (nb.HasValue) ? nb.Value : Convert.ToBoolean(rnd.Next(1));
            }

            return node.StatusProvier.GetStatus(v.GetValue(node.Left, v, context), v.GetValue(node.Right, v, context));
        }
    }
}
//  Potwierdzam samodzielność powyższej pracy oraz niekorzystanie przeze mnie z niedozwolonych źródeł
//  Damian Bis
