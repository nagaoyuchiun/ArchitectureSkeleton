using ArchitectureSkeleton.SqlBulid.Contract.Cell;

namespace ArchitectureSkeleton.SqlBulid.Contract
{
    public interface ISqlBulider : IFormSql
    {
        ISqlQuery<MainTable> Query<MainTable>();
        ISqlInsert<MainTable> Insert<MainTable>();
        ISqlUpdate<MainTable> Update<MainTable>();
        ISqlDelete<MainTable> Delete<MainTable>();
    }
}
