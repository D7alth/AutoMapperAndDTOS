using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapperAndDTOS.Models.Enumerations;

namespace AutoMapperAndDTOS.DTOS.InputModels
{
    public class BookInputModel()
    {
        public string? Id { get; private set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
        public BookEnum Gender { get; set; }
    }
}