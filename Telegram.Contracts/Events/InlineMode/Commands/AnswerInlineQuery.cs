using Telegram.Contracts.DTOs.InlineMode.InlineQueryResults;
using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events.InlineMode.Commands;

/// <summary>
/// Модель для отправки ответов на inline-запрос.
/// </summary>
/// <param name="InlineQueryId">Идентификатор ответа на запрос.</param>
/// <param name="Results">Коллекция результатов для inline-запроса.</param>
/// <param name="CacheTime">Время в секундах в течении которого результат inline-запроса кэшируется на сервере(по умолчанию 300с).</param>
/// <param name="IsPersonal">True - если результаты будут кэшироваться только для пользователя, отправившего запрос<i>(по умолчанию результаты может получить любой пользователь)</i>.</param>
/// <param name="NextOffset">
/// Смещение, которое должен передать клиент в следующем запросе, с тем же текстом, чтобы получить больше результатов.<br />
/// Передается пустая строка, если результатов больше нет или если у вас не поддерживается нумерация страниц.</param>
/// <param name="SwitchPmText">
/// Если передано, то будет отображаться кнопка с указанным текстом, которая переключает пользователя в приватный чат с ботом и отправляет боту<br/>
/// стартовое сообщение(<i>/start</i>) с параметром <b>SwitchPmParameter</b></param>
/// <param name="SwitchPmParameter">
/// Параметр глубокой ссылки для сообщения <i>/start</i>, отправляемого боту, когда пользователь нажимает кнопку переключения(1-64 символа).<br/>
/// Символами могут быть только <b>A-Z</b>, <b>a-z</b>, <b>0-9</b>, <b>_</b> и <b>-</b></param>
public abstract record AnswerInlineQuery(
    string InlineQueryId,
    IEnumerable<InlineQueryResult> Results,
    int? CacheTime,
    bool? IsPersonal,
    string? NextOffset,
    string? SwitchPmText,
    string? SwitchPmParameter)
    : IEventEntity;