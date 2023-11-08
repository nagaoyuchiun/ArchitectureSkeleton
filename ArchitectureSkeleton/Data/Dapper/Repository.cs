using ArchitectureSkeleton.Contract;
using ArchitectureSkeleton.Contract.Repository;
using System.Data;

namespace ArchitectureSkeleton.Data.Dapper
{
    public class Repository<T> : ICommandRepository<T> where T : class
    {
        private readonly IDbConnection _connection;
        private IDbTransaction? _transaction;

        public Repository(IDbConnection connection)
        {
            _connection = connection;
        }

        public void BeginTransaction()
        {
            _transaction = _connection.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _transaction?.Commit();
            _transaction = null;
        }

        public void RollbackTransaction()
        {
            _transaction?.Rollback();
            _transaction = null;
        }

        public T Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public T Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync(long id)
        {
            throw new NotImplementedException();
        }

        public T Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> InsertAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public RepositoryActionResult<T> Update(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<RepositoryActionResult<T>> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
