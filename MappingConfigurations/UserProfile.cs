﻿using AutoMapper;
using AutoMapperDemo.Models;
using AutoMapperDemo.ViewModels;

namespace AutoMapperDemo.MappingConfigurations
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            // Default mapping when property names are same
            CreateMap<User, UserViewModel>();

            // Mapping when property names are different
            //CreateMap<User, UserViewModel>()
            //    .ForMember(dest =>
            //    dest.FName,
            //    opt => opt.MapFrom(src => src.FirstName))
            //    .ForMember(dest =>
            //    dest.LName,
            //    opt => opt.MapFrom(src => src.LastName));
        }
    }

}
