using DotzAvaliacaoTecnica.Domain.Entities;
using System.Collections.Generic;

namespace DotzAvaliacaoTecnica.Domain.Interfaces.Services
{
    public interface IOrdersService
    {
        Orders AddOrder(Orders orders);
        List<Orders> GetOrdersDelivered();
    }
}
