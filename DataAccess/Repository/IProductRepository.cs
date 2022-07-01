using BusinessObject;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts(string? productName, int unitPrice, int unitInStock);

        Product GetProduct(int productId);

        void InsertProduct(Product product);

        void UpdateProduct(Product product);

        void DeleteProduct(int productId);
    }
}
