using DotzAvaliacaoTecnica.Domain.Entities;
using DotzAvaliacaoTecnica.Domain.Interfaces.Infra.Repositories;
using DotzAvaliacaoTecnica.Infra.Repository.Context;
using System.Linq;

namespace DotzAvaliacaoTecnica.Infra.Repository.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        private readonly DotzContext _context;
        public UserRepository(DotzContext context) : base(context)
        {
            _context = context;
        }

        public DotzContext DotzContext
        {
            get { return Context as DotzContext; }
        }

        public User Authenticate(string email, string password)
        {
            var user = _context.Users.Where(u => u.Email == email && u.Password == password).FirstOrDefault();

            return user;
        }
    }
}
