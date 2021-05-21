namespace DotzAvaliacaoTecnica.Domain.Interfaces.Infra.Repositories
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        IAddressRepository AddressRepository { get; }
        IProductsRepository ProductsRepository { get; }
        IPointsRepository PointsRepository { get; }
        IUserExtractRepository UserExtractRepository { get; }
        IOrdersRepository OrdersRepository { get; }
        bool Save();
        void Dispose();
    }
}
