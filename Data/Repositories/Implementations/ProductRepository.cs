using Data.Model;
using Data.Repositories.Interfaces;
using Entidades.Core;

namespace Data.Repositories.Implementations
{
    public class ProductRepository : IProductRepository
    {
        private DataContext _context = new DataContext();
        public IEnumerable<Product> GetProducts()
        {
            return _context.products.ToList();
        }

        public Product GetProductById(int Id)
        {
            Product? product = _context.products.Find(Id);
            return product;
        }

        public IEnumerable<Product> GetProductByText(string text)
        {
            List<Product> res = new List<Product>();
            var product = _context.products.Where(x => x.product.Contains(text)).ToList();
            var description = _context.products.Where(x => x.description.Contains(text)).ToList();

            res.AddRange(product);
            res.AddRange(description);

            return res;
        }

        public void AddProduct(Product Obj)
        {
            _context.products.Add(Obj);
            var o = _context.SaveChanges();
        }

        public string UpdateProduct(Product Obj)
        {
            var product = _context.products.Find(Obj.Id);

            if (product == null)
                return "Producto no encontrado!";

            product.product_id = Obj.product_id;
            product.product = Obj.product;
            product.description = Obj.description;
            product.stock = Obj.stock;
            product.price = Obj.price;
            product.type = Obj.type;
            product.active = Obj.active;

            _context.SaveChanges();

            return "Producto actualizado satisfactoriamente.";
        }

        public string DeleteProduct(int Id)
        {
            var product = _context.products.Find(Id);

            if (product == null)
                return "Producto no encontrado!";

            _context.products.Remove(product);

            _context.SaveChanges();

            return "Producto eliminado satisfactoriamente.";
        }

    }
}
