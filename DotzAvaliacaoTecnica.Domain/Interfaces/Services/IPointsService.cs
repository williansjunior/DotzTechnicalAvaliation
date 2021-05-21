using DotzAvaliacaoTecnica.Domain.Entities;

namespace DotzAvaliacaoTecnica.Domain.Interfaces.Services
{
    public interface IPointsService
    {
        Points AddPoints(Points points);
        Points GetPointsByUserId(int userId);
        Points UpdatePoints(Points points);
    }
}
