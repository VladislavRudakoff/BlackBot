namespace Telegram.Contracts.DTOs.Menu;

public record MenuButtonDefault()
    : MenuButton
{
    protected override string Type { get; init; } = "default";
}