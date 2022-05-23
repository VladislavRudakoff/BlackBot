namespace Telegram.Contracts.DTOs.Chats;

/// <summary>
/// Запрос на присоединение, отправленный в чат.
/// </summary>
/// <param name="Chat">Чат, в который был отправлен запрос.</param>
/// <param name="From">Пользователь, отправивший запрос на присоединение.</param>
/// <param name="Date">Дата отправки запроса(Unix).</param>
/// <param name="Bio">Биография пользователя.</param>
/// <param name="InviteLink">Ссылка, которая использовалась пользователем для отправки запроса на присоединение.</param>
public record ChatJoinRequest(
    Chat Chat,
    User From,
    int Date,
    string? Bio,
    ChatInviteLink? InviteLink);