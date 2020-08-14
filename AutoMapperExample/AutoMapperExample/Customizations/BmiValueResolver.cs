using System;
using AutoMapper;
using AutoMapperExample.DomainModels;
using AutoMapperExample.Models;

namespace AutoMapperExample.Customizations
{
    public class BmiValueResolver : IValueResolver<User, UserViewModel, double>
    {
        public double Resolve(User source, UserViewModel destination, double destMember, ResolutionContext context)
        {
            return Math.Round(source.Weight / Math.Pow(source.Height, 2));
        }
    }
}
