using Data.Repositories.Interfaces;
using Entidades.Core;
using Service.Interfaces;

namespace Service.Implementations
{
    public class ProductService : IProductService
    {
        public IProductRepository _ProductRepository;

        public ProductService(IProductRepository ProductRepository)
        {
            this._ProductRepository = ProductRepository;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return this._ProductRepository.GetProducts();
        }

        public Product GetProductById(int Id)
        {
            return this._ProductRepository.GetProductById(Id);
        }

        public IEnumerable<Product> GetProductByText(string text)
        {
            return this._ProductRepository.GetProductByText(text);
        }
        public void AddProduct(Product Obj)
        {
            this._ProductRepository.AddProduct(Obj);
        }

        public string UpdateProduct(Product Obj)
        {
            return this._ProductRepository.UpdateProduct(Obj);
        }

        public string DeleteProduct(int Id)
        {
            return this._ProductRepository.DeleteProduct(Id);
        }
    }
}
