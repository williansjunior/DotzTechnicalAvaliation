using DotzAvaliacaoTecnica.Domain.Enums;
using DotzAvaliacaoTecnica.DomainCore.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotzAvaliacaoTecnica.Domain.Entities
{
    public class UserExtract : BaseEntity
    {
        [ForeignKey("Fk_Extracts_UserId")]
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public DateTime TransactionDate { get; set; }
        public TransactionTypeEnum TransactionType { get; set; }
        public int InitialPoints { get; set; }
        public int TransactionPoints { get; set; }
        public int PointsBalance { get; set; }

    }
}