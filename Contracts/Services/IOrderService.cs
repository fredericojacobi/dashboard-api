using System.Threading.Tasks;
using Entities.Models;
using Generics.Entities;

namespace Contracts.Services
{
    public interface IOrderService
    {
        Task<OrderPagination> ReadAllOrdersAsync(int currentPage, int recordsPerPage);
        Task<bool> CreateMultipleOrdersAsync(int quantity);
    }
}