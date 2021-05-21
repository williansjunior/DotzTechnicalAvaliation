using DotzAvaliacaoTecnica.Domain.Entities;
using DotzAvaliacaoTecnica.Domain.Interfaces.Infra.Repositories;
using DotzAvaliacaoTecnica.Infra.Repository.Context;

namespace DotzAvaliacaoTecnica.Infra.Repository.Repositories
{
    public class ProductsRepository : RepositoryBase<Products>, IProductsRepository
    {
        private readonly DotzContext _context;
        public ProductsRepository(DotzContext context) : base(context)
        {
            _context = context;
        }
    }
}
