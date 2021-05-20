using DotzAvaliacaoTecnica.API.ViewModel;
using DotzAvaliacaoTecnica.Application.Interfaces;
using DotzAvaliacaoTecnica.Domain.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotzAvaliacaoTecnica.API.Controllers
{
    [AllowAnonymous]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserApplicationService _userAppService;

        public UserController(IUserApplicationService userAppService)
        {
            _userAppService = userAppService;
        }

        
        [HttpPost]
        [Route("Authenticate")]
        public IActionResult Authenticate([FromBody] UserViewModel userViewModel)
        {
            var user = _userAppService.Authenticate(userViewModel.Email, userViewModel.Password);

            if (user == null)
                return NotFound("Usuario não encontrado");

            return Ok(user);
        }

        [HttpPost]
        [Route("")]
        public IActionResult CreateUser([FromBody] UserDTO userDTO)
        {
            var user = _userAppService.Add(userDTO);
            return Ok(user);
        }

        [HttpPut]
        [Route("")]
        public IActionResult UpdateUser([FromBody] UserDTO userDTO)
        {
            var user = _userAppService.Update(userDTO);
            return Ok(user);
        }

        [HttpDelete]
        [Route("")]
        public IActionResult DeleteUser([FromBody] UserDTO userDTO)
        {
            _userAppService.Delete(userDTO);
            return NoContent();
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetAllUsers()
        {
            var users = _userAppService.GetAll();

            return Ok(users);
        }

        [HttpGet]
        [Route("{id}:int")]
        public IActionResult GetById(int id)
        {
            var user = _userAppService.GetById(id);

            if (user == null)
                return NotFound("Usuario não encontrado");

            return Ok(user);
        }

    }
}
