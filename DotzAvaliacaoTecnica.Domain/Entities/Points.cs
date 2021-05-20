using DotzAvaliacaoTecnica.DomainCore.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotzAvaliacaoTecnica.Domain.Entities
{
    public class Points : BaseEntity
    {
        public int TotalPoints { get; set; }
        [ForeignKey("FK_Points_UserId")]
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}