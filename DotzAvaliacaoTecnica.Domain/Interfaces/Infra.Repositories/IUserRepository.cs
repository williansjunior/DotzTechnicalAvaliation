using DotzAvaliacaoTecnica.Domain.Entities;

namespace DotzAvaliacaoTecnica.Domain.Interfaces.Infra.Repositories
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        User Authenticate(string email, string pasword);
    }
}
