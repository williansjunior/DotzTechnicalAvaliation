using DotzAvaliacaoTecnica.Domain.Entities;
using DotzAvaliacaoTecnica.Domain.Interfaces.Infra.Repositories;
using DotzAvaliacaoTecnica.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace DotzAvaliacaoTecnica.Domain.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly IOrdersRepository _repo;

        public OrdersService(IUnitOfWork uow)
        {
            _repo = uow.OrdersRepository;
        }

        public List<Orders> GetOrdersDelivered()
        {
            return _repo.GetOrdersDelivered();
        }

        public Orders AddOrder(Orders orders)
        {
            return _repo.AddOrder(orders);
        }
    }
}
