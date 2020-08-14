using AutoMapper;
using AutoMapperExample.Models;
using AutoMapperExample.DomainModels;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperExample.Controllers
{
    public class UserController : Controller
    {
        private readonly IMapper _mapper;

        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var user = GetUserDetails();
            var userViewModel = _mapper.Map<UserViewModel>(user);

            return View(userViewModel);
        }

        private User GetUserDetails()
        {
            return new User
            {
                Id = 1,
                Address = new Address
                {
                    Street1 = "Laugavegur",
                    City = "Reykjavik",
                    Country = "Iceland"
                },
                AdditionalInfo = new AdditionalInfo
                {
                    PhoneNumber = "+354 321 0025"
                },
                Height = 1.7,
                Weight = 60,
                BirthDate = "11.07.1984",
                Email = "halsey@gmail.com",
                FirstName = "Halsey",
                LastName = "Williams"
            };
        }
    }
}