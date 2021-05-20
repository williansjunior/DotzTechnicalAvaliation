using DotzAvaliacaoTecnica.Domain.Entities;
using System.Collections.Generic;

namespace DotzAvaliacaoTecnica.Domain.Interfaces.Services
{
    public interface IUserService
    {
        List<User> GetAll();
        User GetById(int id);
        User Authenticate(string email, string password);
        User Add(User user);
        User Update(User user);
        void Delete(User user);
    }
}
