using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Contracts.Repositories;
using Contracts.Services;
using Entities.Models;
using Entities.Models.DataTransferObjects;
using Generics.Entities;

namespace Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;

        public OrderService(IRepositoryWrapper repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<OrderPagination> ReadAllOrdersAsync(int currentPage, int recordsPerPage)
        {
            try
            {
                var orders = await _repository.Order.ReadAllOrdersAsync();
                // var ordr = orders.FirstOrDefault();
                var ordersWithoutProducts = orders.Where(x => x.OrdersProducts is null).ToList();

                foreach (var order in ordersWithoutProducts)
                    order.OrdersProducts = await _repository.OrderProduct.ReadOrderProductsByOrderIdAsync(order.Id);

                var data = new RequestData<Order>(orders, currentPage, recordsPerPage);
                var orderPagination = new OrderPagination
                {
                    CurrentPage = data.CurrentPage,
                    HasNext = data.HasNext,
                    HasPrevious = data.HasPrevious,
                    NextPage = data.NextPage,
                    PreviousPage = data.PreviousPage,
                    Records = _mapper.Map<List<OrderDTO>>(data.Records),
                    TotalPages = data.TotalPages,
                    TotalRecords = data.TotalRecords
                };
                return orderPagination;
            }
            catch (Exception e)
            {
                return new OrderPagination();
            }
        }

        public async Task<bool> CreateMultipleOrdersAsync(int quantity)
        {
            try
            {
                var addresses = await _repository.Address.ReadAddressesByQuantityAsync(quantity);
                var teams = await _repository.Team.ReadTeamsByQuantityAsync(quantity);
                var products = await _repository.Product.ReadProductsByQuantityAsync(quantity);
                var orders = new List<Order>();
                for (var i = 0; i < quantity; i++)
                {
                    var orderId = Guid.NewGuid();
                    orders.Add(new()
                    {
                        Id = orderId,
                        AddressId = addresses.FirstOrDefault()?.Id,
                        CreatedAt = DateTime.Now,
                        TeamId = teams.FirstOrDefault()?.Id,
                        OrdersProducts = new List<OrderProduct>
                        {
                            new()
                            {
                                ProductId = products.FirstOrDefault()?.Id,
                                CreatedAt = DateTime.Now,
                                OrderId = orderId
                            }
                        },
                    });
                    if (!addresses.Any())
                        addresses = await _repository.Address.ReadAddressesByQuantityAsync(quantity);
                    if (!teams.Any())
                        teams = await _repository.Team.ReadTeamsByQuantityAsync(quantity);
                    if (!products.Any())
                        products = await _repository.Product.ReadProductsByQuantityAsync(quantity);

                    addresses.RemoveAt(0);
                    teams.RemoveAt(0);
                    products.RemoveAt(0);
                }

                return await _repository.Order.CreateMultipleOrdersAsync(orders);
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}