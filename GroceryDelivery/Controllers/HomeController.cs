using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using GroceryDelivery.BusinessLayer.Features.Order.Commands.Create;
using GroceryDelivery.BusinessLayer.Features;
using GroceryDelivery.BusinessLayer.Features.Queries.GetById;

namespace GroceryDelivery.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public HomeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpPost]
        [Route("place-order")]
        public async Task<IActionResult> CreateOrder(CreateOrderCommand createOrderCommand)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
      

        [HttpGet]
        [Route("get-all-products")]
        public async Task<IActionResult> GetAllProducts()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("product-details")]
        public async Task<IActionResult> ProductDetails(int ProductId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
      

        [HttpGet]
        [Route(("order-info"))]
        public async Task<IActionResult> OrderInfo(int userId)
        {
            var query = new GetOrderByIdQuery { UserId = userId };
            var data = await _mediator.Send(query);
            return Ok(data);
        }
    }
}
       
  