namespace Levolution.Data.Node
{
    public interface IForwardNode<TNode> : INode where TNode : INode
    {
        TNode Next { get; }
    }
}
