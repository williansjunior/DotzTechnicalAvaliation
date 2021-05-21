using DotzAvaliacaoTecnica.Domain.Entities;
using DotzAvaliacaoTecnica.Domain.Interfaces.Infra.Repositories;
using DotzAvaliacaoTecnica.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotzAvaliacaoTecnica.Domain.Services
{
    public class PointsService : IPointsService
    {
        private readonly IPointsRepository _repo;

        public PointsService(IUnitOfWork uow)
        {
            _repo = uow.PointsRepository;
        }

        public Points AddPoints(Points points)
        {
           return _repo.AddPoints(points);
        }

        public Points GetPointsByUserId(int userId)
        {
            return _repo.GetByUserId(userId);
        }

        public Points UpdatePoints(Points points)
        {
             _repo.Update(points);

            return points;
        }
    }
}
