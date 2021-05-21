using DotzAvaliacaoTecnica.Domain.Entities;

namespace DotzAvaliacaoTecnica.Domain.Interfaces.Infra.Repositories
{
    public interface IPointsRepository : IRepositoryBase<Points>
    {
        Points GetByUserId(int userId);
        Points AddPoints(Points points);
    }
}
