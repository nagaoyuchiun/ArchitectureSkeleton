using ArchitectureSkeleton.SqlBulid.Contract.Cell;
using Dapper;

namespace ArchitectureSkeleton.SqlBulid.Contract;

public interface ISqlQuery<MainTable> : IConditional<MainTable>, IAlias<MainTable>
{
    ISqlQuery<MainTable> Select(params string[] args);
    ISqlQuery<MainTable> Distinct();
    ISqlQuery<MainTable> OrderBy(params string[] arg);
    ISqlQuery<MainTable> GroupBy(params string[] arg);
    ISqlQuery<MainTable> Take(int num);
    ISqlQuery<MainTable> Skip(int num);

    ISqlQuery<MainTable> Union<NextTable>(ISqlQuery<NextTable> nextQuery, bool isAll);

    ISqlQuery<MainTable> Having(string arg, ConditionTypes whereType = ConditionTypes.And);
}