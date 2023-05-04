using MediatR;

namespace MediatrTest.Models
{
    public class AddProduct : IRequest<Product>
    {
        public string Name { get; set; }
    }
}
