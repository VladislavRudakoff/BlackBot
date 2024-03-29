﻿using Bot.Data.Enums;

namespace Bot.Contracts.DTOs.Models;

/// <summary>
/// DTO-модель пользователя.
/// </summary>
/// <param name="Id">Идентификатор пользователя.</param>
/// <param name="FullName">Полное имя пользователя.</param>
/// <param name="Username">Юзернейм пользователя.</param>
/// <param name="Role">Роль пользователя.</param>
public record UserDto(int Id, string FullName, string Username, Roles Role);