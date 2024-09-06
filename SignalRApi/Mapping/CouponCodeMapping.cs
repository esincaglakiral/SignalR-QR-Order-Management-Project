using AutoMapper;
using SignalR.DtoLayer.CouponCodeDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class CouponCodeMapping : Profile
    {
        public CouponCodeMapping()
        {
            CreateMap<CouponCode, CreateCouponCodeDto>().ReverseMap();
        }
    }
}
