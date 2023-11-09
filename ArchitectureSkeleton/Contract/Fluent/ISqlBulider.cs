using ArchitectureSkeleton.Contract.Fluent.Cell;

namespace ArchitectureSkeleton.Contract.Fluent
{
    public interface ISqlBulider<MainTable> : IFormSql
    {
        ISqlBulider<MainTable> SetTableName(string tableName);
        ISqlBulider<MainTable> SetPrimaryKey(string key);
        ISqlBulider<MainTable> SetSystemProperty(string prop);
        ISqlBulider<MainTable> SetDisabledProperty(string prop);

        ISqlQuery<MainTable> Query();
        IInsert<MainTable> Insert();
        IUpdate<MainTable> Update();
        IDelete<MainTable> Delete();
    }
}
