using DotzAvaliacaoTecnica.Domain.DTO;
using DotzAvaliacaoTecnica.Domain.ValueObjects;
using DotzAvaliacaoTecnica.DomainCore.Entities;
using System;
using System.Collections.Generic;

namespace DotzAvaliacaoTecnica.Domain.Entities
{
    public class User : BaseEntity
    {
		public string Name { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public DateTime BirthDate { get; set; }
        public virtual Address Address { get; set; }
        public virtual Points Points { get; set; }
        public virtual List<UserExtract> UserExtracts { get; set; }

        
    }
}
