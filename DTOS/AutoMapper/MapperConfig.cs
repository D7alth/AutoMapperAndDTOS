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
    public class MapperConfig
    {
        public static Mapper InitializeAutoMapper()
        {
          var config = 
          new MapperConfiguration(configurationExpression => {
            configurationExpression.CreateMap<BookInputModel, Books>().ReverseMap();
            configurationExpression.CreateMap<BookViewModel, Books>().ReverseMap();
          });
          
          var mapper = new Mapper(config);
          return mapper;
        }
    }
}