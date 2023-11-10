using ArchitectureSkeleton.SqlBulid.Contract;
using ArchitectureSkeleton.SqlBulid.Contract.Cell;

namespace ArchitectureSkeleton.SqlBulid.Concrete
{
    public class SqlBulider : ISqlBulider
    {
        private readonly IServiceProvider _serviceProvider;

        public SqlBulider(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public string FormSql(IParam param)
        {
            throw new NotImplementedException();
        }
        public ISqlQuery<MainTable> Query<MainTable>()
        {
            return _serviceProvider.GetRequiredService<ISqlQuery<MainTable>>();
        }

        public ISqlInsert<MainTable> Insert<MainTable>()
        {
            return _serviceProvider.GetRequiredService<ISqlInsert<MainTable>>();
        }

        public ISqlUpdate<MainTable> Update<MainTable>()
        {
            return _serviceProvider.GetRequiredService<ISqlUpdate<MainTable>>();
        }

        public ISqlDelete<MainTable> Delete<MainTable>()
        {
            return _serviceProvider.GetRequiredService<ISqlDelete<MainTable>>();
        }
    }
}
