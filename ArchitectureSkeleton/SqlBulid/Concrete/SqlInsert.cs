using ArchitectureSkeleton.SqlBulid.Contract;
using ArchitectureSkeleton.SqlBulid.Contract.Cell;
using Dapper;

namespace ArchitectureSkeleton.SqlBulid.Concrete
{
    public class SqlInsert<MainTable> : ISqlInsert<MainTable>
    {
        public IAlias<MainTable> Alias(string arg)
        {
            throw new NotImplementedException();
        }

        public ISqlInsert<MainTable> Columns(params string[] args)
        {
            throw new NotImplementedException();
        }

        public void Parameters(DynamicParameters dynamicParameters)
        {
            throw new NotImplementedException();
        }
    }
}
