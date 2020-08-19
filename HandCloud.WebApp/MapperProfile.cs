using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandCloud.WebApp
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Domain.Car, Models.Car>();
            CreateMap<Models.Car, Domain.Car>();
        }
    }
}
