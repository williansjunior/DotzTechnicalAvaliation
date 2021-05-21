using AutoMapper;
using DotzAvaliacaoTecnica.API.ViewModel;
using DotzAvaliacaoTecnica.Application.Interfaces;
using DotzAvaliacaoTecnica.Domain.DTO;
using DotzAvaliacaoTecnica.Domain.Entities;
using DotzAvaliacaoTecnica.Domain.Interfaces.Services;
using DotzAvaliacaoTecnica.Services;
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
        private readonly IPointsService _pointsService;
        private readonly IUserExtractService _userExtractService;

        public UserController(IUserApplicationService userAppService,
            IPointsService pointsService,
            IUserExtractService userExtractService)
        {
            _userAppService = userAppService;
            _pointsService = pointsService;
            _userExtractService = userExtractService;
        }

        
        [HttpPost]
        [Route("Authenticate")]
        public IActionResult Authenticate([FromBody] UserViewModel userViewModel)
        {
            var userDTO = _userAppService.Authenticate(userViewModel.Email, userViewModel.Password);
            
            if (userDTO == null)
                return NotFound("Usuario não encontrado");

            var user = Mapper.Map<Domain.Entities.User>(userDTO);

            var token = TokenService.GenerateToken(user);

            user.Password = string.Empty;

            return Ok(new {user.Name,token });
        }

        //[Authorize]
        [HttpPost]
        [Route("")]
        public IActionResult CreateUser([FromBody] UserDTO userDTO)
        {
            var user = _userAppService.Add(userDTO);
            return Ok(user);
        }

        //[Authorize]
        [HttpPut]
        [Route("")]
        public IActionResult UpdateUser([FromBody] UserDTO userDTO)
        {
            var user = _userAppService.Update(userDTO);
            return Ok(user);
        }

        //[Authorize]
        [HttpDelete]
        [Route("")]
        public IActionResult DeleteUser([FromBody] UserDTO userDTO)
        {
            _userAppService.Delete(userDTO);
            return NoContent();
        }

        //[Authorize]
        [HttpGet]
        [Route("")]
        public IActionResult GetAllUsers()
        {
            var users = _userAppService.GetAll();

            return Ok(users);
        }

        //[Authorize]
        [HttpGet]
        [Route("{id}:int")]
        public IActionResult GetById(int id)
        {
            var user = _userAppService.GetById(id);

            if (user == null)
                return NotFound("Usuario não encontrado");

            return Ok(user);
        }

        //[Authorize]
        [HttpPost]
        [Route("AddUserPoints")]
        public IActionResult AddUserPoints([FromBody] Points points)
        {
            var user = _userAppService.GetById(points.UserId);


            if (user == null)
                return NotFound("Usuario não encontrado");

            var userPoints = _pointsService.GetPointsByUserId(points.UserId);

            if (userPoints == null)
            {
                var userExtracts = new UserExtract
                {
                    InitialPoints = 0,
                    PointsBalance = points.TotalPoints,
                    TransactionDate = DateTime.Now.Date,
                    TransactionPoints = points.TotalPoints,
                    TransactionType = Domain.Enums.TransactionTypeEnum.Input,
                    UserId = points.UserId
                };
                _userExtractService.AddUserExtract(userExtracts);
                _pointsService.AddPoints(points);
                return Ok(points);
            }
            var userExtract = new UserExtract
            {
                InitialPoints = userPoints.TotalPoints,
                PointsBalance = points.TotalPoints + userPoints.TotalPoints,
                TransactionDate = DateTime.Now.Date,
                TransactionPoints = points.TotalPoints,
                TransactionType = Domain.Enums.TransactionTypeEnum.Input,
                UserId = points.UserId
            };
            _userExtractService.AddUserExtract(userExtract);
            userPoints.TotalPoints += points.TotalPoints;
            _pointsService.UpdatePoints(userPoints);

            return Ok(userPoints);
            
            
        }

        //[Authorize]
        [HttpGet]
        [Route("GetUserPointsByUserId/{id}:int")]
        public IActionResult GetUserPointsByUserId(int id)
        {
            var UserPoints = _pointsService.GetPointsByUserId(id);

            if (UserPoints == null)
                return NotFound("Usuario não encontrado");

            return Ok(UserPoints);
        }

        //[Authorize]
        [HttpGet]
        [Route("GetUserExtractByUserId/{id}:int")]
        public IActionResult GetUserExtractByUserId(int id)
        {
            var UserExtracts = _userExtractService.GetUserExtractsByUserId(id);

            if (UserExtracts == null)
                return NotFound("Usuario não encontrado");

            return Ok(UserExtracts);
        }



    }
}
