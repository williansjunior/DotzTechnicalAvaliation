using DotzAvaliacaoTecnica.Domain.Entities;
using DotzAvaliacaoTecnica.DomainCore.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotzAvaliacaoTecnica.Domain.ValueObjects
{
    public class Address : BaseEntity
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string District { get; set; }

        [ForeignKey("FK_Address_UserId")]
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
