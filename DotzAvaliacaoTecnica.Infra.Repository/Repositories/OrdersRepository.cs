using DotzAvaliacaoTecnica.Domain.Entities;
using DotzAvaliacaoTecnica.Domain.Interfaces.Infra.Repositories;
using DotzAvaliacaoTecnica.Infra.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotzAvaliacaoTecnica.Infra.Repository.Repositories
{
    public class OrdersRepository : RepositoryBase<Orders>, IOrdersRepository
    {
        private readonly DotzContext _context;
        public OrdersRepository(DotzContext context) : base(context)
        {
            _context = context;
        }
        public Orders AddOrder(Orders orders)
        {
            _context.Orders.Add(orders);
            _context.SaveChanges();

            return orders;
        }

        public List<Orders> GetOrdersDelivered()
        {
            return _context.Orders.Where(o => o.DeliveredStatus == Domain.Enums.OrderDeliveredStatusEnum.Delivered).ToList();
        }
    }
}
