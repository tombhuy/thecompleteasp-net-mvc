using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using _4_FirstApplication.Dtos;
using _4_FirstApplication.Models;

namespace _4_FirstApplication.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();

        }
    }
}