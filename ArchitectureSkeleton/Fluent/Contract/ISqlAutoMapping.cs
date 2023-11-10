namespace ArchitectureSkeleton.Fluent.Contract
{
    public interface ISqlAutoMapping<Table>
    {
        string TableName { get; }
        IEnumerable<string> PrimaryKeys { get; }
        IEnumerable<string> SystemPropertys { get; }
        IEnumerable<string> DisabledPropertys { get; }

        ISqlAutoMapping<Table> SetTableName(string tableName);
        ISqlAutoMapping<Table> SetPrimaryKeys(params string[] key);
        ISqlAutoMapping<Table> SetSystemProperty(params string[] prop);
        ISqlAutoMapping<Table> SetDisabledProperty(params string[] prop);

        string Query();
        string Query(int id);
        string Insert(Table table);
        string Update(Table table);
        string Delete(int id);
    }
}
