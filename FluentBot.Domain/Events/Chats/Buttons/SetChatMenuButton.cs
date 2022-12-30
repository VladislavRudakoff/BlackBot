namespace FluentBot.Domain.UseCases.Events.Chats.Buttons;

/// <summary>
/// Модель для изменения кнопки меню бота в приватном чате или кнопки меню по умолчанию.
/// </summary>
/// <param name="ChatId">Идентификатор чата(если null - кнопка меню бота по умолчанию будет изменена).</param>
/// <param name="MenuButton">Новая кнопка меню бота(по умолчанию <see cref="FluentBot.Domain.Entities.Menu.MenuButtonDefault"/>).</param>
public record SetChatMenuButton(
    ChatId? ChatId,
    MenuButton? MenuButton)
    : IEventEntity;