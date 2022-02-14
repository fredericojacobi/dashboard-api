namespace Contracts.Repositories
{
    public interface IRepositoryWrapper
    {
        IOrderRepository Order { get; }
    }
}