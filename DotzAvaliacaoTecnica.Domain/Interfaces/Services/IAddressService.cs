using DotzAvaliacaoTecnica.Domain.ValueObjects;

namespace DotzAvaliacaoTecnica.Domain.Interfaces.Services
{
    public interface IAddressService
    {
        Address AddUserAddress(Address address);
        Address GetUserAddressByUserId(int userId);
    }
}
