using AutoMapper;
using Bot.Contracts.DTO.Enums;
using Bot.Contracts.DTO.Models;
using Bot.Data.Enums;
using Bot.Data.Models;
using Bot.Logic.Providers.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Bot.WebApi.Controllers;

/// <summary>
/// Контроллер для работы с пользователями.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class UserController : Controller
{
    private readonly IUserProvider userProvider;
    private readonly IMapper mapper;

    /// <summary>
    /// ctor.
    /// </summary>
    /// <param name="userProvider"><see cref="IUserProvider"/>.</param>
    /// <param name="mapper"><see cref="IMapper"/></param>
    public UserController(IUserProvider userProvider, IMapper mapper)
    {
        this.userProvider = userProvider;
        this.mapper = mapper;
    }

    /// <summary>
    /// Возвращает список всех пользователей.
    /// </summary>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Список всех пользователей.</returns>
    [HttpGet]
    public async Task<IEnumerable<UserDto>> GetAllUsers(CancellationToken cancellationToken = default)
    {
        IEnumerable<User> users = await userProvider.GetAllUsers(cancellationToken);

        return mapper.Map<IEnumerable<UserDto>>(users);
    }

    /// <summary>
    /// Возвращает пользователя по идентификатору.
    /// </summary>
    /// <param name="userId">Идентификатор пользователя.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Пользователь с нужным идентификатором.</returns>
    [HttpGet("{userId:int}")]
    public async Task<ActionResult<UserDto>> GetUsersById(int userId, CancellationToken cancellationToken = default)
    {
        User? user = await userProvider.GetUserById(userId, cancellationToken);

        if (user is null)
        {
            return NotFound();
        }

        return mapper.Map<UserDto>(user);
    }

    /// <summary>
    /// Возвращает все роли по идентификатору пользователя.
    /// </summary>
    /// <param name="userId">Идентификатор пользователя.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Роли пользователя.</returns>
    [HttpGet("{userId}/role")]
    public async Task<RoleDto> GetUserRoles(long userId, CancellationToken cancellationToken = default)
    {
        Role userRole = await userProvider.GetUserRoles(userId, cancellationToken);

        return mapper.Map<RoleDto>(userRole);
    }

    /// <summary>
    /// Возвращает пользователя по юзернейму.
    /// </summary>
    /// <param name="username">Юзернейм пользователя.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Пользователь, полученный по юзернейму.</returns>
    [HttpGet("{username}")]
    public async Task<ActionResult<UserDto?>> GetUserByUsername(string username,
        CancellationToken cancellationToken = default)
    {
        User? user = await userProvider.GetUserByUsername(username, cancellationToken);

        if (user is null)
        {
            return NotFound();
        }

        return mapper.Map<UserDto>(user);
    }
}