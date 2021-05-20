using AutoMapper;
using DotzAvaliacaoTecnica.Application.Interfaces;
using DotzAvaliacaoTecnica.Domain.DTO;
using DotzAvaliacaoTecnica.Domain.Entities;
using DotzAvaliacaoTecnica.Domain.Interfaces.Infra.Repositories;
using DotzAvaliacaoTecnica.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace DotzAvaliacaoTecnica.Application.ApplicationServices
{
    public class UserApplicationService : BaseApplicationService, IUserApplicationService
    {
        private readonly IUserService _service;
        public UserApplicationService(IUnitOfWork uow,
            IUserService service) : base(uow)
        {
            _service = service;
        }

        public UserDTO Add(UserDTO userDTO)
        {
            var user = Mapper.Map<User>(userDTO);
            var result = _service.Add(user);
            Commit();

            return Mapper.Map(result, new UserDTO());
        }

        public UserDTO Authenticate(string email, string password)
        {
            var user = _service.Authenticate(email, password);
            if (user == null)
                return null;

            return Mapper.Map(user, new UserDTO());
        }

        public void Delete(UserDTO userDTO)
        {
            var user = Mapper.Map<User>(userDTO);

            _service.Delete(user);
            Commit();
        }

        public List<UserDTO> GetAll()
        {
            var users = _service.GetAll();

            return Mapper.Map(users, new List<UserDTO>());
        }

        public UserDTO GetById(int id)
        {
            var user = _service.GetById(id);

            if (user == null)
                return null;

            return Mapper.Map(user, new UserDTO());
        }

        public UserDTO Update(UserDTO userDTO)
        {
            var user = Mapper.Map<User>(userDTO);
            var result = _service.Update(user);
            Commit();

            return Mapper.Map(result, new UserDTO());
        }
    }
}
