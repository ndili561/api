using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;


namespace WebApi.Mapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            //CreateMap<Response, ResponseDTO>().ForMember(src => src.name, opt => opt.MapFrom(src => src.email));
            //CreateMap<ResponseDTO, Response>();
        }
    }
}
