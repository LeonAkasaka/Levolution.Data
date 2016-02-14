namespace Levolution.Data.Node
{
    public interface IBidirectionalNode : INode
    {
        INode Next { get; }

        INode Previous { get; }
    }
}
