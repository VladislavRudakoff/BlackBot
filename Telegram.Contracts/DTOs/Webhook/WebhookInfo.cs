namespace Telegram.Contracts.DTOs.Webhook;

/// <summary>
/// Описывает текущее состояние webhook'а. 
/// </summary>
/// <param name="Url">Url-адрес webhook'а.</param>
/// <param name="HasCustomCertificate">True - если для проверки сертификата webhook'а был предоставлен пользовательский сертификат.</param>
/// <param name="PendingUpdateCount">Количество обновлений, ожидающих доставки.</param>
/// <param name="IdAddress">Текущий IP-адрес webhook'а.</param>
/// <param name="LastErrorDate">Дата(Unix) самой последней произошедшей ошибки доставки обновления через webhook.</param>
/// <param name="LastErrorMessage">Сообщение об ошибке в удобочитаемом формате для самой последней ошибки доставки обновления через webhook.</param>
/// <param name="LastSynchronizationErrorDate">Время самой последней ошибки, произошедшей при попытке синхронизировать обновления с центрами обработки данных Telegram.</param>
/// <param name="MaxConnections">Максимально допустимое количество одновременных подключений(HTTPS) к webhook'у.</param>
/// <param name="AllowedUpdates">Список типов обновлений, на которые подписан бот(по умолчанию все типы обновлений, кроме ChatMember).</param>
public record WebhookInfo(
    string Url,
    bool HasCustomCertificate,
    int PendingUpdateCount,
    string? IdAddress,
    int? LastErrorDate,
    string? LastErrorMessage,
    int? LastSynchronizationErrorDate,
    int? MaxConnections,
    IEnumerable<string>? AllowedUpdates);