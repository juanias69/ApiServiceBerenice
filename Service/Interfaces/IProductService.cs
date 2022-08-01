using Entidades.Core;

namespace Service.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int Id);
        IEnumerable<Product> GetProductByText(string text);
        void AddProduct(Product Obj);
        string UpdateProduct(Product Obj);
        string DeleteProduct(int Id);
    }
}
