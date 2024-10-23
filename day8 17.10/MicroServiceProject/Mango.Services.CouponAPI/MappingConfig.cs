using AutoMapper;
using Mango.Services.CouponAPI.Models;
using Mango.Services.CouponAPI.Models.Dto;


namespace Mango.Services.CouponAPI
{

    public class MappingConfig:Profile
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(Config =>
            {
                Config.CreateMap<CouponDto, Coupon>();
                Config.CreateMap<Coupon, CouponDto>();

            });
            return mappingConfig;
        }
    //    public MappingConfig() { 
    //        CreateMap<CouponDto, Coupon>();
    //        CreateMap<Coupon, CouponDto>();
    //    }
    }
}
