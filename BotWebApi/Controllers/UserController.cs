using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Bot.Contracts.DTO;
using Bot.Data.Models;
using Bot.Logic.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Bot.WebApi.Controllers;

/// <summary>
/// Контроллер для работы с пользователями.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class UserController: Controller
{
    private readonly IUserProvider userProvider;
    private readonly IMapper mapper;

    public UserController(IUserProvider userProvider, IMapper mapper)
    {
        this.userProvider = userProvider;
        this.mapper = mapper;
    }

    [HttpGet]
    public async Task<IEnumerable<UserDto>> GetAllUsers(CancellationToken cancellationToken = default)
    {
        IEnumerable<User> users = await userProvider.GetAllUsers(cancellationToken);

        return mapper.Map<IEnumerable<UserDto>>(users);
    }
}
