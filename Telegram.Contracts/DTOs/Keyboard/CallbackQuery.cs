using Telegram.Contracts.DTOs.Messages;

namespace Telegram.Contracts.DTOs.Keyboard;

/// <summary>
/// Объект представляет входящий callback-вызов от callback кнопки на встроенной клавиатуре.
/// </summary>
/// <param name="Id">Уникальный идентификатор запроса.</param>
/// <param name="User">Отправитель.</param>
/// <param name="Message">Сообщение с callback-кнопкой, которая инициировала запрос.</param>
/// <param name="InlineMessageId">Идентификатор сообщения, которое инициировало запрос.</param>
/// <param name="ChatInstance">Глобальный идентификатор чата в который было отправлено сообщение с callback-кнопкой.</param>
/// <param name="Data">Данные, связанные с callback-кнопкой.</param>
public record CallbackQuery(
    string Id,
    User User,
    Message? Message,
    string? InlineMessageId,
    string ChatInstance,
    string? Data);