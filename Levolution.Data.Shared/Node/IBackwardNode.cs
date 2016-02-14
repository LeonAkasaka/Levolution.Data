namespace Levolution.Data.Node
{
    public interface IBackwardNode : INode
    {
        INode Previous { get; }
    }
}
