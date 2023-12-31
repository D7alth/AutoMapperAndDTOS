using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapperAndDTOS.Models.Enumerations;

namespace AutoMapperAndDTOS.DTOS.ViewModels
{
    public class BookViewModel()
    {
        public string? Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
        public BookEnum Gender { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;

    }
}