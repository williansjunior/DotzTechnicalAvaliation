using DotzAvaliacaoTecnica.Domain.Entities;
using DotzAvaliacaoTecnica.Domain.Interfaces.Infra.Repositories;
using DotzAvaliacaoTecnica.Infra.Repository.Context;
using System.Linq;

namespace DotzAvaliacaoTecnica.Infra.Repository.Repositories
{
    public class PointsRepository : RepositoryBase<Points>, IPointsRepository
    {
        private readonly DotzContext _context;
        public PointsRepository(DotzContext context) : base(context)
        {
            _context = context;
        }

        public Points AddPoints(Points points)
        {
            _context.Points.Add(points);
            _context.SaveChanges();

            return points;
        }

        public Points GetByUserId(int userId)
        {
            return _context.Points.Where(x => x.UserId == userId).FirstOrDefault();
        }
    }
}
