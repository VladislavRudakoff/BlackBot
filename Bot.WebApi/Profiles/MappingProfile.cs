using AutoMapper;
using Bot.Contracts.DTOs.Enums;
using Bot.Contracts.DTOs.Models;
using Bot.Data.DboModels;
using Bot.Data.Enums;

namespace Bot.WebApi.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<UserDto, UserDbo>().ReverseMap();
        CreateMap<RolesDto, Roles>().ReverseMap();
    }
}