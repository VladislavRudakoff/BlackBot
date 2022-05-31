namespace Telegram.Contracts.DTOs;

/// <summary>
/// Пользователь.
/// </summary>
/// <param name="Id">Идентификатор пользователя.</param>
/// <param name="IsBot">True, если этот пользователь - бот.</param>
/// <param name="FirstName">Имя.</param>
/// <param name="LastName">Фамилия.</param>
/// <param name="Username">Юзернейм.</param>
/// <param name="LanguageCode">Языковой тег IETF.</param>
/// <param name="CanJoinGroups">True, если бота можно приглашать в группы.</param>
/// <param name="CanReadAllGroupMessages">True, если для бота отключен режим конфиденциальности.</param>
/// <param name="SupportsInlineQueries">True, если бот поддерживает встроенные запросы.</param>
public record User(
    long Id,
    bool IsBot,
    string FirstName,
    string? LastName,
    string? Username,
    string? LanguageCode,
    bool? CanJoinGroups,
    bool? CanReadAllGroupMessages,
    bool? SupportsInlineQueries);