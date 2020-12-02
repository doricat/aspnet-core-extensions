namespace WebApi.Filter
{
    public class UnaryExpressionNode : OperatingNode
    {
        public UnaryExpressionNode(string @operator, NodeType type) : base(@operator, type)
        {
        }
    }
}