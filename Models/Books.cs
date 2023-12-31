using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapperAndDTOS.Models.Enumerations;

namespace AutoMapperAndDTOS.Models
{
    public class Books
    {
      public Books(Guid id, string title, string description, string author, BookEnum gender, bool active = true)
      {
        if(string.IsNullOrWhiteSpace(title)) throw new ArgumentNullException("Title is null or empty");
        if(string.IsNullOrWhiteSpace(description)) throw new ArgumentNullException("Description is null or empty");
        if(string.IsNullOrWhiteSpace(author)) throw new ArgumentNullException("Author is null or empty");
        
        Id = id;
        Title = title;
        Description = description;
        Author = author;
        Gender = gender;
        Active = active;
      }
        public Guid Id { get; private set; }
        public string? Title { get; private set; }
        public string? Description { get; private set; }
        public string? Author { get; private set; }
        public BookEnum Gender { get; private set; }
        public bool Active { get; private set; } = true;
        public DateTime DateCreated { get; private set; } = DateTime.Now;
        public DateTime DateUpdated { get; private set; } = DateTime.Now;
    }
}