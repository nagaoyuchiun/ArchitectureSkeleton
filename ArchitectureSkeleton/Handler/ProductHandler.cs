using ArchitectureSkeleton.Contract.Handler;
using ArchitectureSkeleton.Contract.Repository;
using ArchitectureSkeleton.Data.Dapper;
using ArchitectureSkeleton.Model;
using System.Data;

namespace ArchitectureSkeleton.Handler
{
    public class ProductHandler : IProductHandler
    {
        private readonly ICommandRepository<Product> _productRepository;
        private readonly IDbConnection _connection;

        public ProductHandler(ICommandRepository<Product> productRepository, IDbConnection _connection)
        {
            _productRepository = productRepository;
            this._connection = _connection;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

        public Product GetProductById(int id)
        {
            return _productRepository.Get(id);
        }

        public int CreateProduct(Product product)
        {
            return _productRepository.Insert(product).Id;
        }

        public void UpdateProduct(Product product)
        {
            _productRepository.Update(product);
        }

        public void CreateAndUpdateProduct(Product product)
        {
            using (_connection)
            {
                try
                {
                    _connection.Open();
                    _productRepository.BeginTransaction();

                    _productRepository.Insert(product);
                    _productRepository.Update(product);

                    _productRepository.CommitTransaction();
                }
                catch
                {
                    _productRepository.RollbackTransaction();
                    throw;
                }
                finally
                {
                    _connection.Close();
                }
            }
        }
    }
}
