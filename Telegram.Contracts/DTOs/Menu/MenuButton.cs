namespace Telegram.Contracts.DTOs.Menu;

/// <summary>
/// Кнопка меню бота в приватном чате.
/// </summary>
public abstract record MenuButton()
{
    protected abstract string Type { get; init; };
}