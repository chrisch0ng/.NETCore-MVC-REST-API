using AutoMapper;
using Commander.Dtos;
using Commander.Models;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Commander.Profiles

{
    public class CommandsProfile : Profile 
    {
        public CommandsProfile()
        {
            // source -> target : reads command from database and passes back to client, source is the command, target is a CommandReadDto
            
            CreateMap<Command, CommandReadDto>(); 
            CreateMap<CommandCreateDto, Command>(); // so now we need to translate it back to a command 

            CreateMap<CommandUpdateDto, Command>(); // now its for UpdateCommand in CommandsController

            CreateMap<Command, CommandUpdateDto>();
        
        }
    }

}