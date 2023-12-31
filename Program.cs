using AutoMapperAndDTOS.DTOS.AutoMapper;
using AutoMapperAndDTOS.DTOS.InputModels;
using AutoMapperAndDTOS.DTOS.ViewModels;
using AutoMapperAndDTOS.Models;
using AutoMapperAndDTOS.Models.Enumerations;

var BookObjectModel = new Books(Guid.NewGuid(), "Clean code", "A cool book", "Robert C. Martin", BookEnum.Fantasy);

Console.WriteLine(
$" Object result = "  + 
$"{BookObjectModel.Id}" + 
$"{BookObjectModel.Title}"  +  
$"{BookObjectModel.Description}" + 
$"{BookObjectModel.Author}" + 
$"{BookObjectModel.Gender}" +
$"{BookObjectModel.DateCreated}"
);

var mapper = MapperConfig.InitializeAutoMapper();
var bookDTO1 = mapper.Map<BookInputModel>(BookObjectModel);
var bookDTO2 = mapper.Map<BookViewModel>(bookDTO1);

Console.WriteLine(
$" Input model result = "  + 
$"{bookDTO1.Id} "  +  
$"{bookDTO1.Title} "  +  
$"{bookDTO1.Description} " + 
$"{bookDTO1.Author} " + 
$"{bookDTO1.Gender}" +
$"\n" 
);

Console.WriteLine(
$" View model result = "  + 
$"{bookDTO2.Id} "  +  
$"{bookDTO2.Title} "  +  
$"{bookDTO2.Description} " + 
$"{bookDTO2.Author} " + 
$"{bookDTO2.Gender} " +
$"{bookDTO2.DateCreated}" +
$"\n" 
);