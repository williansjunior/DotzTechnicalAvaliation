using DotzAvaliacaoTecnica.Domain.Entities;
using DotzAvaliacaoTecnica.Domain.Interfaces.Infra.Repositories;
using DotzAvaliacaoTecnica.Infra.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotzAvaliacaoTecnica.Infra.Repository.Repositories
{
    public class UserExtractRepository : RepositoryBase<UserExtract>, IUserExtractRepository
    {
        private readonly DotzContext _context;
        public UserExtractRepository(DotzContext context) : base(context)
        {
            _context = context;
        }
        public UserExtract AddUserExtract(UserExtract userExtract)
        {
            _context.UserExtracts.Add(userExtract);
            _context.SaveChanges();

            return userExtract;
        }

        public List<UserExtract> GetUserExtractsByUserId(int userId)
        {
            return _context.UserExtracts.Where(u => u.UserId == userId).ToList();
        }
    }
}
