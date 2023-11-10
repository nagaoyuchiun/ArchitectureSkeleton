using ArchitectureSkeleton.SqlBulid.Contract;
using ArchitectureSkeleton.SqlBulid.Contract.Cell;
using Dapper;

namespace ArchitectureSkeleton.SqlBulid.Concrete
{
    public class SqlQuery<MainTable> : ISqlQuery<MainTable>
    {
        public IAlias<MainTable> Alias(string arg)
        {
            throw new NotImplementedException();
        }

        public ISqlQuery<MainTable> Distinct()
        {
            throw new NotImplementedException();
        }

        public ISqlQuery<MainTable> GroupBy(params string[] arg)
        {
            throw new NotImplementedException();
        }

        public ISqlQuery<MainTable> Having(string arg, ConditionTypes whereType = ConditionTypes.And)
        {
            throw new NotImplementedException();
        }

        public IConditional<MainTable> Join<SubTable>(string left, string right, Comparisons comparison, JoinTypes joinType = JoinTypes.Inner, string alias = "")
        {
            throw new NotImplementedException();
        }

        public ISqlQuery<MainTable> OrderBy(params string[] arg)
        {
            throw new NotImplementedException();
        }

        public void Parameters(DynamicParameters dynamicParameters)
        {
            throw new NotImplementedException();
        }

        public ISqlQuery<MainTable> Select(params string[] args)
        {
            throw new NotImplementedException();
        }

        public ISqlQuery<MainTable> Skip(int num)
        {
            throw new NotImplementedException();
        }

        public ISqlQuery<MainTable> Take(int num)
        {
            throw new NotImplementedException();
        }

        public ISqlQuery<MainTable> Union<NextTable>(ISqlQuery<NextTable> nextQuery, bool isAll)
        {
            throw new NotImplementedException();
        }

        public IConditional<MainTable> Where(string condition, ConditionTypes conditionType = ConditionTypes.And)
        {
            throw new NotImplementedException();
        }
    }
}
