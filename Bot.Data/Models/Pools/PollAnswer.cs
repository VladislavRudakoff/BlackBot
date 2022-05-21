using System.Collections.Generic;

namespace Bot.Data.Models.Pools;

/// <summary>
/// Ответ пользователя в <b>НЕ</b>анонимном опросе.
/// </summary>
/// <param name="PollId">Идентификатор опроса.</param>
/// <param name="User">Пользователь, оставивший голос.</param>
/// <param name="OptionIds">Идентификаторы вариантов ответов, выбранных пользователей.</param>
public record PollAnswer(
    string PollId,
    UserDbo User,
    IEnumerable<int> OptionIds);