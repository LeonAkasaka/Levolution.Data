namespace Levolution.Data.Node
{
    public interface IForwardNode : INode
    {
        INode Next { get; }
    }
}
