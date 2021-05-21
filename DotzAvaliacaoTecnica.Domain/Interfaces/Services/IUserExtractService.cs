using DotzAvaliacaoTecnica.Domain.Entities;
using System.Collections.Generic;

namespace DotzAvaliacaoTecnica.Domain.Interfaces.Services
{
    public interface IUserExtractService
    {
        List<UserExtract> GetUserExtractsByUserId(int userId);
        UserExtract AddUserExtract(UserExtract userExtract);
    }
}
