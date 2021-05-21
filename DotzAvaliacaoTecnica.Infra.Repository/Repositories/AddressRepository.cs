using DotzAvaliacaoTecnica.Domain.Interfaces.Infra.Repositories;
using DotzAvaliacaoTecnica.Domain.ValueObjects;
using DotzAvaliacaoTecnica.Infra.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotzAvaliacaoTecnica.Infra.Repository.Repositories
{
    public class AddressRepository : RepositoryBase<Address>, IAddressRepository
    {
        private readonly DotzContext _context;
        public AddressRepository(DotzContext context) : base(context)
        {
            _context = context;
        }

        public Address GetUserAddressByUserId(int userId)
        {
            var address = _context.Addresses.Where(x => x.UserId == userId).FirstOrDefault();

            return address;
        }
    }
}
