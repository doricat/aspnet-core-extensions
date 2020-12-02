namespace WebApi.Filter
{
    public enum NodeType : byte
    {
        None,
        UnaryLogicalExpression,
        BinaryLogicalExpression,
        RelationalExpression,
        Property,
        Constant
    }
}