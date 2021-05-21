using DotzAvaliacaoTecnica.Domain.Entities;
using DotzAvaliacaoTecnica.Domain.Interfaces.Infra.Repositories;
using DotzAvaliacaoTecnica.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace DotzAvaliacaoTecnica.Domain.Services
{
    public class UserExtractService : IUserExtractService
    {
        private readonly IUserExtractRepository _repo;

        public UserExtractService(IUnitOfWork uow)
        {
            _repo = uow.UserExtractRepository;
        }
        public UserExtract AddUserExtract(UserExtract userExtract)
        {
            return _repo.AddUserExtract(userExtract);
        }

        public List<UserExtract> GetUserExtractsByUserId(int userId)
        {
            return _repo.GetUserExtractsByUserId(userId);
        }
    }
}
