namespace FluentBot.Domain.Entities.Entities;

/// <summary>
/// Объект для отображения пользователю интерфейса ответа.
/// </summary>
/// <param name="InputFieldPlaceholder">Заполнитель, который будет отображаться в поле ввода, когда ответ активен.</param>
/// <param name="Selective">Параметр, используемый для получения ответов только от определенных пользователей: <br />
/// - Пользователи @упомянутые в тексте сообщения <br />
/// - Если сообщение бота является ответом на сообщение пользователя.</param>
/// <param name="ShowForceReply">Показывает интерфейс ответа пользователю, как если бы он вручную выбрал сообщение бота и нажал «Ответить».</param>
public record ForceReply(
    string? InputFieldPlaceholder,
    bool? Selective, 
    bool ShowForceReply = true)
    : IInterfaceOptions;