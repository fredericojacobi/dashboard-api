using AutoMapper;
using Entities.Models;
using Entities.Models.DataTransferObjects;
using Generics.Entities;

namespace DashboardAPI
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Order, OrderDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(x => x.Address))
                .ForMember(dest => dest.Team, opt => opt.MapFrom(x => x.Team))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(x => x.CreatedAt))
                .ForMember(dest => dest.DeliveredAt, opt => opt.MapFrom(x => x.DeliveredAt))
                .ForMember(dest => dest.ModifiedAt, opt => opt.MapFrom(x => x.DeliveredAt))
                .ForMember(dest => dest.OrdersProducts, opt => opt.MapFrom(x => x.OrdersProducts));
        }
    }
}