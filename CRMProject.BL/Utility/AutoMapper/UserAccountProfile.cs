using AutoMapper;
using CRMProject.DTO.Pages;
using CRMProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMProject.BL.Utility.AutoMapper
{
    using DTO.Pages;
    public class UserAccountProfile : Profile
    {
        public UserAccountProfile()
        {
            CreateMap<UserAccountDTO, UserAccount>();//.ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName)).ForMember(dest=>dest.Password, opt=>opt.MapFrom(src => src.Password));
            CreateMap<UserAccount, UserAccountDTO>();

        }
    }
}
