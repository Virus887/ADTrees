using System;
using System.Collections.Generic;
using System.Text;
using Task;

namespace Lab8.EvaluateVisitors
{
    interface IEvaluateVisitor<T>
    {
        T GetValue(IADTreeNode node, IEvaluateVisitor<T> v, ADTreeContext context);
    }
}
