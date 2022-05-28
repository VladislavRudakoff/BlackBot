using System.Collections.Generic;

namespace Telegram.Contracts.DTOs.Pools;

/// <summary>
/// Ответ пользователя в <b>НЕ</b>анонимном опросе.
/// </summary>
/// <param name="PollId">Идентификатор опроса.</param>
/// <param name="User">Пользователь, оставивший голос.</param>
/// <param name="OptionIds">Идентификаторы вариантов ответов, выбранных пользователей.</param>
public record PollAnswer(
    string PollId,
    User User,
    IEnumerable<int> OptionIds);