using AutoMapper;
using MVC_REST_API.DTOs;
using S2E3.Models;

namespace MVC_REST_API.Profiles
{
    public class CommandsProfile : Profile
    {
        //!AhmedShaban: Just creat Create maps
        public CommandsProfile()
        {
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
        }
    }
}
