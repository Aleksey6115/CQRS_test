using MediatrTest.Models;

namespace MediatrTest.Repositories
{
    public interface IProductRepository
    {
        public Task<Product> Add(AddProduct addProduct);
    }
}
