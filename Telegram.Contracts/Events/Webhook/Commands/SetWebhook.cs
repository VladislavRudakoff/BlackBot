using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events.Webhook.Commands;

/// <summary>
/// Модель для установки webhook'а.
/// </summary>
/// <param name="Url">URL-адрес HTTPS для отправки обновлений.</param>
/// <param name="IpAddress">Фиксированный IP-адрес, который будет использоваться для отправки запросов веб-перехватчика вместо IP-адреса, разрешенного через DNS.</param>
/// <param name="MaxConnections">Максимально допустимое количество одновременных подключений(HTTPS) к webhook'у(по умолчанию 40).</param>
/// <param name="AllowedUpdates">Список типов обновлений, на которые подписан бот(по умолчанию все типы обновлений, кроме ChatMember).</param>
/// <param name="DropPendingUpdates">True - если требуется удалить все ожидающие обновления.</param>
/// <param name="SecretToken">
/// Секретный токен, для отправки в заголовке <i>"X-Telegram-Bot-Api-Secret-Token"</i> в каждом запросе webhook'а(1-256 символов)<br/>
/// Символами могут быть только <b>A-Z</b>, <b>a-z</b>, <b>0-9</b>, <b>_</b> и <b>-</b>.<br/><br/>
/// <b>Заголовок полезен для того, чтобы убедиться, что запрос исходит от установленного вами веб-перехватчика.</b>
/// </param>
public record struct SetWebhook(
    string Url,
    string? IpAddress,
    int? MaxConnections,
    IEnumerable<string>? AllowedUpdates,
    bool? DropPendingUpdates,
    string? SecretToken)
    : IEventEntity
{
    /// <summary>
    /// Конструктор для webhook'а только с url.
    /// </summary>
    /// <param name="url">URL-адрес HTTPS для отправки обновлений.</param>
    public SetWebhook(string url) 
        : this(url, null, null, null, null, null)
    {
    }
}