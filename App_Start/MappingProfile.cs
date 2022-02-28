using ASP220214V4.Dtos;
using ASP220214V4.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP220214V4.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Ugyfel, UgyfelDto>();
            Mapper.CreateMap<UgyfelDto, Ugyfel>();
        }
    }
}