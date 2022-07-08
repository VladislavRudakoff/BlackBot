namespace Telegram.Contracts.DTOs.Stickers;

/// <summary>
/// Позиция маски.
/// </summary>
/// <param name="Point">Часть лица относительно которой должна располагаться маска.</param>
/// <param name="XShift">Сдвиг по оси X. Например, если выбрать -1.0, то маска будет сдвинута влево от положения по умолчанию.</param>
/// <param name="YShift">Сдвиг по оси Y. Например, если выбрать 1.0, то маска будет сдвинута вниз от положения по умолчанию.</param>
/// <param name="Scale">Коэффициент масштабирования маски. Например, 2.0 означает двойной размер.</param>
public record MaskPosition(
    string Point,
    double XShift,
    double YShift,
    double Scale);