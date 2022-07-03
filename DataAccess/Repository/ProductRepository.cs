using BusinessObject;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _context = new();

        public IEnumerable<Product> GetProducts(string? productName, decimal unitPrice, int unitInStock)
        {
            if (_context.Products == null)
            {
                throw new Exception("Connection failed.");
            }

            var products = _context.Products.AsQueryable();

            if (productName != null)
            {
                products = products.Where(p => p.ProductName.Contains(productName));
            }

            if (unitPrice > 0)
            {
                products = products.Where(p => p.UnitPrice <= unitPrice);
            }

            if (unitInStock > 0)
            {
                products = products.Where(p => p.UnitInStock <= unitInStock);
            }

            return products.ToList();
        }

        public Product GetProduct(int productId)
        {
            if (_context.Members == null)
            {
                throw new Exception("Connection failed.");
            }

            var product = _context.Products.Find(productId);

            if (product == null)
            {
                throw new Exception("Not found.");
            }

            return product;
        }

        public void InsertProduct(Product product)
        {
            if (_context.Products == null)
            {
                throw new Exception("Connection failed.");
            }

            _context.Products.Add(product);

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateProduct(Product product)
        {
            if (_context.Products == null)
            {
                throw new Exception("Connection failed.");
            }

            _context.Entry(product).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteProduct(int productId)
        {
            if (_context.Products == null)
            {
                throw new Exception("Connection failed.");
            }

            var product = _context.Members.Find(productId);

            if (product == null)
            {
                throw new Exception("Not found.");
            }

            _context.Remove(product);
            _context.SaveChanges();
        }
    }
}
