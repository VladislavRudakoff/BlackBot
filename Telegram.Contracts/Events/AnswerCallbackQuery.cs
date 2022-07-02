using Telegram.Contracts.DTOs.Keyboard;
using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events;

/// <summary>
/// Модель для отправки ответа на <see cref="CallbackQuery"/>, отправленные с <see cref="InlineKeyboardMarkup"/>.
/// </summary>
/// <param name="CallbackQueryId">Идентификатор запроса, на который нужно ответить.</param>
/// <param name="Text">Текст уведомления(0-200 символов). Если не указано, не покажет ничего.</param>
/// <param name="Url">URL-адрес, который будет открыт телеграм клиентом пользователя.</param>
/// <param name="ShowAlert">True - если нужно отобразить ответ в виде предупреждения(по умолчанию False).</param>
/// <param name="CacheTime">Максимальное время в секундах, в течение которого результат запроса обратного вызова может кэшироваться на стороне клиента(по умолчанию 0).</param>
public record AnswerCallbackQuery(
    string CallbackQueryId,
    string? Text,
    string? Url,
    bool? ShowAlert = false,
    int? CacheTime = 0)
    : IEventEntity;