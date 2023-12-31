﻿using ArchitectureSkeleton.Model;

namespace ArchitectureSkeleton.Contract.Handler
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
