using Lab8.Nodes;
using System;

namespace Task
{
    interface IADTreeNode
    {
        string Name { get; set; }
        int Duration { get; set; }
        int Cost { get; set; }

        IADTreeNode Left { get; set; }
        IADTreeNode Right { get; set; }

        IStatusProvider StatusProvier { get;}
        ICostProvider CostProvider { get; }
        IDurationProvider DurationProvider { get; }
    }

    class AndNode: IADTreeNode
    {
        public AndNode(string name, int duration, int cost, IADTreeNode left=null, IADTreeNode right=null)
        {
            Name = name;
            Duration = duration;
            Cost = cost;
            Left = left;
            Right = right;
        }

        public string Name { get; set; }
        public int Duration { get; set; }
        public int Cost { get; set; }
        public IADTreeNode Left { get; set; }
        public IADTreeNode Right { get; set; }

        public IStatusProvider StatusProvier => new ANDStatus();
        public ICostProvider CostProvider => new ANDMinCost();
        public IDurationProvider DurationProvider => new ANDMinDuration();
    }

    class OrNode : IADTreeNode
    {
        public OrNode(string name, int duration, int cost, IADTreeNode left = null, IADTreeNode right = null)
        {
            Name = name;
            Duration = duration;
            Cost = cost;
            Left = left;
            Right = right;
        }

        public IADTreeNode Left { get; set; }
        public IADTreeNode Right { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int Cost { get; set; }

        public IStatusProvider StatusProvier => new ORStatus();
        public ICostProvider CostProvider =>new ORMinCost();
        public IDurationProvider DurationProvider => new ORMinDuration();
    }

    class LeafNode : IADTreeNode
    {
        public LeafNode(string name, int duration, int cost, IADTreeNode left = null, IADTreeNode right = null)
        {
            Name = name;
            Duration = duration;
            Cost = cost;
            Left = left;
            Right = right;
        }

        public IADTreeNode Left { get; set; }
        public IADTreeNode Right { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int Cost { get; set; }

        public IStatusProvider StatusProvier => throw new NotImplementedException();
        public ICostProvider CostProvider => throw new NotImplementedException();
        public IDurationProvider DurationProvider => throw new NotImplementedException();
    }
}
//  Potwierdzam samodzielność powyższej pracy oraz niekorzystanie przeze mnie z niedozwolonych źródeł
//  Damian Bis
