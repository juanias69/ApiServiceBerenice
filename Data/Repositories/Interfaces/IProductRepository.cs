using Entidades.Core;

namespace Data.Repositories.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int Id);
        IEnumerable<Product> GetProductByText(string text);
        void AddProduct(Product Obj);
        string UpdateProduct(Product Obj);
        string DeleteProduct(int Id);
    }
}
