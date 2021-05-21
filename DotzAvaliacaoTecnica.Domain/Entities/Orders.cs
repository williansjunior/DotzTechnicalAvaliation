using DotzAvaliacaoTecnica.Domain.Enums;
using DotzAvaliacaoTecnica.DomainCore.Entities;
using System;

namespace DotzAvaliacaoTecnica.Domain.Entities
{
    public class Orders : BaseEntity
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public OrderDeliveredStatusEnum DeliveredStatus { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
