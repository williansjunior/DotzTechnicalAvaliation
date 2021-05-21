using DotzAvaliacaoTecnica.Domain.Entities;
using System.Collections.Generic;

namespace DotzAvaliacaoTecnica.Domain.Interfaces.Infra.Repositories
{
    public interface IUserExtractRepository : IRepositoryBase<UserExtract>
    {
        List<UserExtract> GetUserExtractsByUserId(int userId);
        UserExtract AddUserExtract(UserExtract userExtract);
    }
}
