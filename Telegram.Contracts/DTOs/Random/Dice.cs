namespace Telegram.Contracts.DTOs.Random;

/// <summary>
/// Игральная кость.
/// </summary>
/// <param name="Emoji">Смайл на котором основан бросок костей.</param>
/// <param name="Value">Опциональное значение, для разных смайлов значение может быть в пределах от 1 до 64.</param>
public record Dice(
    string Emoji,
    int Value);