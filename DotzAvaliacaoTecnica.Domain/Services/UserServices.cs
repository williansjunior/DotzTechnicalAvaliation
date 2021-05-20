using DotzAvaliacaoTecnica.Domain.Entities;
using DotzAvaliacaoTecnica.Domain.Interfaces.Infra.Repositories;
using DotzAvaliacaoTecnica.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotzAvaliacaoTecnica.Domain.Services
{
    public class UserServices : IUserService
    {
        private readonly IUserRepository _repo;

        public UserServices(IUnitOfWork uow)
        {
            _repo = uow.UserRepository;
        }

        public User Add(User user)
        {
            _repo.Add(user);
            return user;
        }

        public User Authenticate(string email, string password)
        {
            return _repo.Authenticate(email, password);
        }

        public void Delete(User user)
        {
            _repo.Remove(user);
        }

        public List<User> GetAll()
        {
            return _repo.GetAll().ToList();
        }

        public User GetById(int id)
        {
            return _repo.Get(id);
        }

        public User Update(User user)
        {
             _repo.Update(user);
            return user;
        }
    }
}
