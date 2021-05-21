using DotzAvaliacaoTecnica.Application.Interfaces;
using DotzAvaliacaoTecnica.Domain.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DotzAvaliacaoTecnica.API.Controllers
{

    [Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressApplicationService _addressAppService;
        private readonly IUserApplicationService _userAppService;

        public AddressController(IAddressApplicationService addressAppService, IUserApplicationService userAppService)
        {
            _addressAppService = addressAppService;
            _userAppService = userAppService;
        }

        [HttpPost]
        [Route("AddUserAddress")]
        public IActionResult AddUserAddress([FromBody] AddressDTO addressDTO)
        {
            var user = _userAppService.GetById(addressDTO.UserId);

            if (user == null) return NotFound("Usuario não cadastrado");

            var userAddress = _addressAppService.AddUserAddress(addressDTO);

            return Ok(userAddress);
        }

        [HttpGet]
        [Route("GetUserAddressByUserId/{id}:int")]
        public IActionResult GetUserAddressByUserId(int id)
        {
            var userAddress = _addressAppService.GetUserAddressByUserId(id);

            if (userAddress == null) return NotFound("Usuario não cadastrado");

            return Ok(userAddress);
        }
    }
}
