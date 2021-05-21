using DotzAvaliacaoTecnica.Application.Interfaces;
using DotzAvaliacaoTecnica.Domain.DTO;
using DotzAvaliacaoTecnica.Domain.Entities;
using DotzAvaliacaoTecnica.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DotzAvaliacaoTecnica.API.Controllers
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsApplicationService _productsAppService;
        private readonly IOrdersService _ordersService;
        private readonly IUserApplicationService _userAppService;
        private readonly IPointsService _pointsService;
        private readonly IUserExtractService _userExtractService;
        

        public ProductsController(IProductsApplicationService productsAppService,
            IOrdersService ordersService,
            IUserApplicationService userAppService,
            IUserExtractService userExtractService,
            IPointsService pointsService)
        {
            _productsAppService = productsAppService;
            _ordersService = ordersService;
            _userAppService = userAppService;
            _pointsService = pointsService;
            _userExtractService = userExtractService;
        }

        [HttpPost]
        [Route("")]
        public IActionResult AddProducts([FromBody] ProductsDTO productsDTO)
        {
            var product = _productsAppService.AddProducts(productsDTO);

            return Ok(product);
        }

        [HttpGet]
        [Route("ProductsAvailableToRescue")]
        public IActionResult GetProductsAvailableToRescue()
        {
            var products = _productsAppService.GetProductsAvailableToRescue();

            return Ok(products);
        }

        [HttpPost]
        [Route("RescueProducts")]
        public IActionResult RescueProducts([FromBody] Orders orders)
        {
            var userPoints = _pointsService.GetPointsByUserId(orders.UserId);
            var product = _productsAppService.GetById(orders.ProductId);

            if (userPoints.TotalPoints < product.RescuePoints) return BadRequest("O saldo de pontos é menor que o total de pontos do produto");

            var userExtract = new UserExtract
            {
                InitialPoints = userPoints.TotalPoints,
                PointsBalance = userPoints.TotalPoints - product.RescuePoints,
                TransactionDate = DateTime.Now.Date,
                TransactionPoints = product.RescuePoints,
                TransactionType = Domain.Enums.TransactionTypeEnum.Output,
                UserId = orders.UserId
            };
            orders.CreatedAt = DateTime.Now.Date;

            _userExtractService.AddUserExtract(userExtract);
            _ordersService.AddOrder(orders);

            return Ok(orders);

        }
    }
}
