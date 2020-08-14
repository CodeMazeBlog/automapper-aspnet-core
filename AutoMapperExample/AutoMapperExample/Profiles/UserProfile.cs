using System;
using AutoMapper;
using AutoMapperExample.Customizations;
using AutoMapperExample.Models;
using AutoMapperExample.DomainModels;

namespace AutoMapperExample.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<string, DateTime>().ConvertUsing<DateTimeTypeConverter>();
            CreateMap<User, UserViewModel>()
                .ForMember(dest => dest.HasSecondaryAddress, opt => opt.MapFrom(src => string.IsNullOrEmpty(src.Address.Street2)))
                .ForMember(dest => dest.Bmi, opt => opt.MapFrom<BmiValueResolver>())
                .IncludeMembers(u => u.Address, u => u.AdditionalInfo);
            CreateMap<Address, UserViewModel>(MemberList.None);
            CreateMap<AdditionalInfo, UserViewModel>(MemberList.None);
        }
    }
}