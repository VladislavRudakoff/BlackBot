using Telegram.Contracts.DTOs.InlineMode.ContentOfInputMessages;
using Telegram.Contracts.DTOs.Locations;

namespace Telegram.Contracts.DTOs.InlineMode;

/// <summary>
/// Представляет результат inline-запроса, который был выбран пользователем и отправлен собеседнику.
/// </summary>
/// <remarks>Необходимо включить inline feedback через @BotFather, чтобы получать этот объект в обновлениях.</remarks>
/// <param name="ResultId">Идентификатор выбранного результата.</param>
/// <param name="From">Пользователь, выбравший результат.</param>
/// <param name="Query">Запрос, который использовался для получения результата.</param>
/// <param name="Location">Местоположение отправителя(только для ботов, которым требуется местоположение пользователя).</param>
/// <param name="InlineMessageId">
/// Идентификатор отправленного inline-сообщения(доступно, только если к сообщению подключена встроенная клавиатура).<br/>
/// Также будет получен в Callback-запросах и может быть использован для редактирования сообщения. 
/// </param>
public record ChosenInlineResult(
    string ResultId,
    User From,
    string Query,
    Location? Location,
    string? InlineMessageId)
    : InputMessageContent;