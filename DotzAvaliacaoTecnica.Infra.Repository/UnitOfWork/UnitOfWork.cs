using DotzAvaliacaoTecnica.Domain.Interfaces.Infra.Repositories;
using DotzAvaliacaoTecnica.Infra.Repository.Context;

namespace DotzAvaliacaoTecnica.Infra.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
		private readonly DotzContext _context;

        
        public UnitOfWork(DotzContext context,
			IUserRepository userRepository,
			IAddressRepository addressRepository,
			IProductsRepository productsRepository,
			IPointsRepository pointsRepository,
			IUserExtractRepository userExtractRepository,
			IOrdersRepository ordersRepository)
        {
            _context = context;
			UserRepository = userRepository;
			AddressRepository = addressRepository;
			ProductsRepository = productsRepository;
			PointsRepository = pointsRepository;
			UserExtractRepository = userExtractRepository;
			OrdersRepository = ordersRepository;

        }

		public IUserRepository UserRepository { get; private set; }
		public IAddressRepository AddressRepository { get; private set; }

        public IProductsRepository ProductsRepository { get; private set; }

        public IPointsRepository PointsRepository { get; private set; }

        public IUserExtractRepository UserExtractRepository { get; private set; }

        public IOrdersRepository OrdersRepository { get; set; }

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
