namespace Contracts.Services
{
    public interface IServiceWrapper
    {
        IOrderService Order { get; }
        IUserService User { get; }
        ITokenService Token { get; }
    }
}