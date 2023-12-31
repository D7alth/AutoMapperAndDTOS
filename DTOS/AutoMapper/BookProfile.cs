using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapperAndDTOS.DTOS.InputModels;
using AutoMapperAndDTOS.DTOS.ViewModels;
using AutoMapperAndDTOS.Models;

namespace AutoMapperAndDTOS.DTOS.AutoMapper
{
    public class BookProfile : Profile
    {
        public BookProfile()
        {
          CreateMap<BookInputModel, Books>().ReverseMap();
          CreateMap<BookViewModel, Books>().ReverseMap();
        }
    }
}