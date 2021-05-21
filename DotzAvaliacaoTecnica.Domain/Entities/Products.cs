using DotzAvaliacaoTecnica.Domain.Enums;
using DotzAvaliacaoTecnica.DomainCore.Entities;

namespace DotzAvaliacaoTecnica.Domain.Entities
{
    public class Products : BaseEntity
    {
        public string ProductName { get; set; }
        public int RescuePoints { get; set; }
        public ProductsAvailableRescueEnum Available { get; set; }
    }
}
