using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.DTOs.Interfaces;
using Telegram.Contracts.Events.Common.Interfaces;

namespace Telegram.Contracts.Events.Common.Polls;

/// <summary>
/// Модель для отправки опроса.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="Question">Вопрос(1-300символов).</param>
/// <param name="Options">Список вариантов ответов(2-10 строк по 1-100 символов каждая).</param>
/// <param name="AllowsMultipleAnswers">True - если опрос допускает несколько ответов(игнорируется в режиме викторины).</param>
/// <param name="CorrectOptionId">Идентификатор правильного ответа(начиная с 0).</param>
/// <param name="Explanation">Текст, который отображается, когда пользователь выбирает неправильный ответ или нажимает на значок лампы в опросе в стиле викторины <br />
/// <b>Ограничения: 0-200 символов, с не более чем двумя переносами строки после форматирования.</b></param>
/// <param name="ExplanationParseMode">Тип форматирования.</param>
/// <param name="ExplanationEntities">Список специальных сущностей, которые появляются в объяснении.</param>
/// <param name="OpenPeriod">Время в секундах, в течение которого опрос будет активен после создания(5-600).</param>
/// <param name="CloseDate">Момент времени(Unix), когда опрос будет автоматически закрыт(5-600с от текущего времени).</param>
/// <param name="IsClosed">True - если требуется закрыть опрос.</param>
/// <param name="DisableNotification">Отключает уведомление о сообщении.</param>
/// <param name="ProtectContent">Защищает содержимое отправленного сообщения от пересылки и сохранения.</param>
/// <param name="ReplyToMessageId">Идентификатор исходного сообщения, если текущее сообщение является ответом.</param>
/// <param name="AllowSendingWithoutReply">True если сообщение всё равно должно быть отправлено, даже если не найдено связанное.</param>
/// <param name="ReplyMarkup">Дополнительные возможности интерфейса.</param>
/// <param name="IsAnonymous">True - если опрос должен быть анонимным.</param>
/// <param name="Type">Тип опроса(викторина(quiz) или обычный(regular))</param>
public record SendPoll(
    ChatId ChatId,
    string Question,
    IEnumerable<string> Options,
    bool? AllowsMultipleAnswers,
    int? CorrectOptionId,
    string? Explanation,
    string? ExplanationParseMode,
    string? ExplanationEntities,
    int? OpenPeriod,
    int? CloseDate,
    bool? IsClosed,
    bool? DisableNotification,
    bool? ProtectContent,
    int? ReplyToMessageId,
    bool? AllowSendingWithoutReply,
    IInterfaceOptions? ReplyMarkup,
    bool? IsAnonymous = true,
    string? Type = "regular")
    : IEventEntity;