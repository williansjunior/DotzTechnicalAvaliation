using DotzAvaliacaoTecnica.Domain.ValueObjects;

namespace DotzAvaliacaoTecnica.Domain.Interfaces.Infra.Repositories
{
    public interface IAddressRepository : IRepositoryBase<Address>
    {
        Address GetUserAddressByUserId(int userId);
    }
}
