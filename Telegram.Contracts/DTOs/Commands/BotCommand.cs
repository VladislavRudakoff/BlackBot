namespace Telegram.Contracts.DTOs.Commands;

/// <summary>
/// Команда бота.
/// </summary>
/// <param name="Command">Текст команды(от 1 до 32 символов). <b>Может содержать только строчные английские буквы, цифры и символы подчеркивания.</b></param>
/// <param name="Description">Описание команды(от 1 до 256 символов).</param>
public record BotCommand(
    string Command,
    string Description);