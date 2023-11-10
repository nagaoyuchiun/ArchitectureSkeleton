using ArchitectureSkeleton.SqlBulid.Contract;
using ArchitectureSkeleton.SqlBulid.Contract.Cell;
using Dapper;

namespace ArchitectureSkeleton.SqlBulid.Concrete
{
    public class SqlUpdate<MainTable> : ISqlUpdate<MainTable>
    {
        public IAlias<MainTable> Alias(string arg)
        {
            throw new NotImplementedException();
        }

        public IConditional<MainTable> Join<SubTable>(string left, string right, Comparisons comparison, JoinTypes joinType = JoinTypes.Inner, string alias = "")
        {
            throw new NotImplementedException();
        }

        public void Parameters(DynamicParameters dynamicParameters)
        {
            throw new NotImplementedException();
        }

        public ISqlUpdate<MainTable> Set(string arg)
        {
            throw new NotImplementedException();
        }

        public IConditional<MainTable> Where(string condition, ConditionTypes conditionType = ConditionTypes.And)
        {
            throw new NotImplementedException();
        }
    }
}
