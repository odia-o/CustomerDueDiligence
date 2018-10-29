using AutoMapper;
using CustomerDueDiligence.Dtos;
using CustomerDueDiligence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerDueDiligence.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<AccountType, AccountTypeDto>();

            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}