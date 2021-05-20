using DotzAvaliacaoTecnica.Domain.DTO;
using System.Collections.Generic;

namespace DotzAvaliacaoTecnica.Application.Interfaces
{
    public interface IUserApplicationService
    {
        List<UserDTO> GetAll();
        UserDTO GetById(int id);
        UserDTO Authenticate(string email, string password);
        UserDTO Add(UserDTO user);
        UserDTO Update(UserDTO user);
        void Delete(UserDTO user);
    }
}
