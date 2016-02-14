namespace Levolution.Data.Node
{
    public interface IBackwardNode<TNode> : INode where TNode : INode
    {
        TNode Previous { get; }
    }
}
