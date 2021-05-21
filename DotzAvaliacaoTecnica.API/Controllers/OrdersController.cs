using DotzAvaliacaoTecnica.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DotzAvaliacaoTecnica.API.Controllers
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrdersService _ordersService;

        public OrdersController(IOrdersService ordersService)
        {
            _ordersService = ordersService;
        }

        [HttpGet]
        [Route("OrdersDelivered")]
        public IActionResult GetOrdersDelivered()
        {
            var orders = _ordersService.GetOrdersDelivered();

            return Ok(orders);
        }
    }
}
