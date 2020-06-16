using AutoMapper;
using MarfazahFashion.Dtos;
using MarfazahFashion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarfazahFashion.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(m => m.Id, opt => opt.Ignore());
            Mapper.CreateMap<Curtain, CurtainDto>();
            Mapper.CreateMap<CurtainDto, Curtain>().ForMember(m => m.Id, opt => opt.Ignore());
        }
    }
}