using ArchitectureSkeleton.Contract.Fluent.Cell;

namespace ArchitectureSkeleton.Contract.Fluent
{
    public interface ISqlBulider : IFormSql
    {
        ISqlQuery<MainTable> Query<MainTable>();
        ISqlInsert<MainTable> Insert<MainTable>();
        ISqlUpdate<MainTable> Update<MainTable>();
        ISqlDelete<MainTable> Delete<MainTable>();
    }
}
