using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Bot.Contracts.DTO;
using Bot.Data.Models;
using Bot.Logic.Providers.Interfaces;
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
    [HttpGet("Users/{userId}")]
    public async Task<ActionResult<UserDto>> GetUsersById(int userId, CancellationToken cancellationToken = default)
    {
        User? currentUser = await userProvider.GetUserById(userId, cancellationToken);

        if (currentUser is null)
        {
            return NotFound();
        }

        return mapper.Map<UserDto>(currentUser);
    }
}
