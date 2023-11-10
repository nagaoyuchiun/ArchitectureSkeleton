using Dapper;

namespace ArchitectureSkeleton.Fluent.Contract.Cell
{
    public interface IConditional<MainTable> : IParam
    {
        IConditional<MainTable> Where(string condition, ConditionTypes conditionType = ConditionTypes.And);
        IConditional<MainTable> Join<SubTable>(string left, string right, Comparisons comparison, JoinTypes joinType = JoinTypes.Inner, string alias = "");
    }
}
