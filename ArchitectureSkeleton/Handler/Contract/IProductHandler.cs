using ArchitectureSkeleton.Model;

namespace ArchitectureSkeleton.Handler.Contract
{
    public interface IProductHandler
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
        int CreateProduct(Product product);
        void UpdateProduct(Product product);
        void CreateAndUpdateProduct(Product product);
    }
}
