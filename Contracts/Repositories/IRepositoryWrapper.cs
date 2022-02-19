namespace Contracts.Repositories
{
    public interface IRepositoryWrapper
    {
        IOrderRepository Order { get; }
        IAddressRepository Address { get; }
        IOrderProductRepository OrderProduct { get; }
        IProductRepository Product { get; }
        ITeamRepository Team { get; }
        IUserRepository User { get; }
        IVehicleRepository Vehicle { get; }
    }
}