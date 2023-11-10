using ArchitectureSkeleton.SqlBulid.Contract;

namespace ArchitectureSkeleton.SqlBulid.Concrete
{
    public class SqlAutoMapping<Table> : ISqlAutoMapping<Table>
    {
        public string TableName { get; private set; } = string.Empty;

        public IEnumerable<string> PrimaryKeys { get; private set; } = Enumerable.Empty<string>();


        public IEnumerable<string> SystemPropertys { get; private set; } = Enumerable.Empty<string>();

        public IEnumerable<string> DisabledPropertys { get; private set; } = Enumerable.Empty<string>();

        public ISqlAutoMapping<Table> SetTableName(string tableName)
        {
            throw new NotImplementedException();
        }

        public ISqlAutoMapping<Table> SetPrimaryKeys(params string[] key)
        {
            throw new NotImplementedException();
        }

        public ISqlAutoMapping<Table> SetSystemProperty(params string[] prop)
        {
            throw new NotImplementedException();
        }

        public ISqlAutoMapping<Table> SetDisabledProperty(params string[] prop)
        {
            throw new NotImplementedException();
        }
        public string Query()
        {
            throw new NotImplementedException();
        }

        public string Query(int id)
        {
            throw new NotImplementedException();
        }

        public string Insert(Table table)
        {
            throw new NotImplementedException();
        }

        public string Update(Table table)
        {
            throw new NotImplementedException();
        }

        public string Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
