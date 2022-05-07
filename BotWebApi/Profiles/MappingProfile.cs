using AutoMapper;
using Bot.Contracts.DTO.Enums;
using Bot.Contracts.DTO.Models;
using Bot.Data.Enums;
using Bot.Data.Models;

namespace Bot.WebApi.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<UserDto, User>().ReverseMap();
        CreateMap<RoleDto, Role>().ReverseMap();
    }
}