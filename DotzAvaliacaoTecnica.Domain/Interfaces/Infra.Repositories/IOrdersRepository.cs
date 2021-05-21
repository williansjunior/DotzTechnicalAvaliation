using DotzAvaliacaoTecnica.Domain.Entities;
using System.Collections.Generic;

namespace DotzAvaliacaoTecnica.Domain.Interfaces.Infra.Repositories
{
    public interface IOrdersRepository : IRepositoryBase<Orders>
    {
        Orders AddOrder(Orders orders);
        List<Orders> GetOrdersDelivered();
    }
}
