using MediatrTest.Models;

namespace MediatrTest.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public async Task<Product> Add(AddProduct addProduct)
        {
            List<Product> products = new List<Product>();
            Product product = new Product() { Id = 1, Name = addProduct.Name };
            products.Add(product);

            return await Task.FromResult(product);
        }
    }
}
