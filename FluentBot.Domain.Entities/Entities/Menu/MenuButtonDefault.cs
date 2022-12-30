namespace FluentBot.Domain.Entities.Entities.Menu;

public record MenuButtonDefault()
    : MenuButton
{
    protected override string Type { get; init; } = "default";
}