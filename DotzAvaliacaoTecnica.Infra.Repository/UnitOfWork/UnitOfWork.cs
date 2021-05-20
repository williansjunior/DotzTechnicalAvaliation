using DotzAvaliacaoTecnica.Domain.Interfaces.Infra.Repositories;
using DotzAvaliacaoTecnica.Infra.Repository.Context;

namespace DotzAvaliacaoTecnica.Infra.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
		private readonly DotzContext _context;

        
        public UnitOfWork(DotzContext context,
			IUserRepository userRepository)
        {
            _context = context;
			UserRepository = userRepository;
        }

		public IUserRepository UserRepository { get; private set; }

		public bool Save()
		{
			return _context.SaveChanges() >= 0;
		}

		public void Dispose()
		{
			_context.Dispose();
		}
	}
}
