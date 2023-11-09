namespace ArchitectureSkeleton.Contract.Fluent
{
    public interface ISqlAutoMapping<MainTable>
    {
        ISqlAutoMapping<MainTable> SetTableName(string tableName);
        ISqlAutoMapping<MainTable> SetPrimaryKey(string key);
        ISqlAutoMapping<MainTable> SetSystemProperty(string prop);
        ISqlAutoMapping<MainTable> SetDisabledProperty(string prop);

        string Query();
        string Query(int id);
        string Insert(MainTable table);
        string Update(MainTable table);
        string Delete(int id);
    }
}
