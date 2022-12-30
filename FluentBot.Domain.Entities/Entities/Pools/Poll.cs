namespace FluentBot.Domain.Entities.Entities.Pools;

/// <summary>
/// Опрос.
/// </summary>
/// <param name="Id">Идентификатор опроса.</param>
/// <param name="Question">Вопрос(от 1 до 100 символов).</param>
/// <param name="Options">Список вариантов ответа.</param>
/// <param name="TotalVoterCount">Общее кол-во проголосовавших.</param>
/// <param name="IsClosed"><b>True</b>, если опрос закрыт.</param>
/// <param name="IsAnonymous">True, если опрос анонимный.</param>
/// <param name="Type">Тип опроса(может быть обычным опросом или викториной).</param>
/// <param name="AllowsMultipleAnswers">True, если можно выбрать несколько вариантов.</param>
/// <param name="CorrectOptionId">Идентификатор правильного варианта ответа(для викторины).</param>
/// <param name="Explanation">Текст, который отображается, когда пользователь выбирает неправильный ответ или нажимает значок лампы(от 0 до 200 символов)</param>
/// <param name="ExplanationEntities">Список сущностей, которые появляются в <i>объяснении</i>.</param>
/// <param name="OpenPeriod">Время, в течении которого опрос будет активен, в секундах.</param>
/// <param name="CloseDate">Момент времени, когда опрос будет автоматически закрыт(Unix).</param>
public record Poll(
    string Id,
    string Question,
    IEnumerable<PollOption> Options,
    int TotalVoterCount,
    bool IsClosed,
    bool IsAnonymous,
    string Type,
    bool AllowsMultipleAnswers,
    int? CorrectOptionId,
    string? Explanation,
    IEnumerable<MessageEntity>? ExplanationEntities,
    int? OpenPeriod,
    int? CloseDate);