namespace Bot.Data.Models;

/// <summary>
/// Пользователь.
/// </summary>
/// <param name="UserId">Идентификатор пользователя.</param>
/// <param name="IsBot">True, если этот пользователь - бот.</param>
/// <param name="FirstName">Имя.</param>
/// <param name="LastName">Фамилия.</param>
/// <param name="UserName">Юзернейм.</param>
/// <param name="LanguageCode">Языковой тег IETF.</param>
/// <param name="CanJoinGroups">True, если бота можно приглашать в группы.</param>
/// <param name="CanReadAllGroupMessages">True, если для бота отключен режим конфиденциальности.</param>
/// <param name="SupportsInlineQueries">True, если бот поддерживает встроенные запросы.</param>
public record User(
    long UserId,
    bool IsBot,
    string FirstName,
    string? LastName,
    string? UserName,
    string? LanguageCode,
    bool? CanJoinGroups,
    bool? CanReadAllGroupMessages,
    bool? SupportsInlineQueries);