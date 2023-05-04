using MediatR;
using MediatrTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace MediatrTest.Controllers
{
    [Route("/[action]")]
    public class HomeController : Controller
    {
        private readonly IMediator _mediator;

        public HomeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> AddProductTODO([FromBody] AddProduct newProduct, CancellationToken cancellationToken)
        {
            await _mediator.Send(newProduct, cancellationToken);
            return Ok("Успех");
        }
    }
}
