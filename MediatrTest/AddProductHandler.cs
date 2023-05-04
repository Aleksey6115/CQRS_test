using MediatR;
using MediatrTest.Models;
using MediatrTest.Repositories;

namespace MediatrTest
{
    public class AddProductHandler : IRequestHandler<AddProduct, Product>
    {
        private readonly IProductRepository _productRepository;

        public AddProductHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> Handle(AddProduct request, CancellationToken cancellationToken)
        {
            return await _productRepository.Add(request);
        }
    }
}
