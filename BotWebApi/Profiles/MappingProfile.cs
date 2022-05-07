using AutoMapper;
using Bot.Contracts.DTO;
using Bot.Data.Models;

namespace Bot.WebApi.Profiles;

public class MappingProfile: Profile
{
    public MappingProfile()
    {
        CreateMap<UserDto, User>().ReverseMap();
    }
}