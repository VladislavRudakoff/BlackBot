namespace FluentBot.Domain.Entities.Entities.Messages;

/// <summary>
/// Сообщение.
/// </summary>
/// <param name="MessageId">Идентификатор сообщения.</param>
/// <param name="From">Отправитель сообщения.</param>
/// <param name="SenderChat">Отправитель сообщения, отправленного от имени чата.</param>
/// <param name="Date">Дата отправки сообщения(Unix).</param>
/// <param name="ForwardFrom">Для переадресованных сообщений - отправитель исходного сообщения.</param>
/// <param name="Chat">Чат, которому принадлежит сообщение</param>
/// <param name="ForwardFromChat">Информация об исходном чате отправителя(для сообщений, переадресованных с каналов или от анонимных администраторов).</param>
/// <param name="ForwardFromMessageId">Идентификатор исходного сообщения в канале(для сообщений, пересылаемых из каналов).</param>
/// <param name="ForwardSignature">Подпись отправителя сообщения, если она присутствует(для переадресованных сообщений).</param>
/// <param name="ForwardSenderName">Имя отправителя для сообщений, переадресованных пользователями, которые запрещают добавлять ссылку на свою учетную запись в пересылаемых сообщениях.</param>
/// <param name="ForwardDate">Дата отправки исходного сообщения(Unix)(для переадресованных сообщений).</param>
/// <param name="IsAutomaticForward">True - если сообщение представляет собой публикацию канала, которая была автоматически перенаправлена ​​в подключенную группу обсуждения.</param>
/// <param name="ReplyToMessage">Исходное сообщение(для ответов).</param>
/// <param name="ViaBot">Бот, через которого было отправлено сообщение.</param>
/// <param name="EditDate">Дата последнего редактирования сообщения(Unix).</param>
/// <param name="HasProtectedContent">True - если сообщение не может быть переадресовано.</param>
/// <param name="MediaGroupId">Уникальный идентификатор группы медиа-сообщений.</param>
/// <param name="AuthorSignature">Подпись автора поста(для сообщений в каналах) или пользовательский заголовок анонимного администратора группы.</param>
/// <param name="Text">Текст сообщения(UTF-8).</param>
/// <param name="Entities">Особые сущности сообщения.</param>
/// <param name="Animation">Анимация.</param>
/// <param name="Audio">Звуковой файл.</param>
/// <param name="Document">Обычный файл.</param>
/// <param name="Photo">Фото.</param>
/// <param name="Video">Видео.</param>
/// <param name="VideoNote">Видеозаметка.</param>
/// <param name="Voice">Голосовое сообщение.</param>
/// <param name="Caption">Подпись к анимации, аудио, документу, фото, видео или голосовому сообщению.</param>
/// <param name="CaptionEntities">Специальные объекты(для сообщений с заголовком).</param>
/// <param name="Contact">Контакт.</param>
/// <param name="Dice">Кубик со случайным значением.</param>
/// <param name="Poll">Опрос.</param>
/// <param name="Venue">Место проведения.</param>
/// <param name="Location">Местоположение.</param>
/// <param name="NewChatMembers">Новые участники, которые были добавлены в группу или супергруппу.</param>
/// <param name="LeftChatMember">Удаленный из группы участник.</param>
/// <param name="NewChatTitle">Новое название чата.</param>
/// <param name="NewChatPhoto">Новая фотография чата.</param>
/// <param name="DeleteChatPhoto">Служебное сообщение: фото чата удалено.</param>
/// <param name="GroupChatCreated">Служебное сообщение: группа создана.</param>
/// <param name="SupergroupChatCreated">Служебное сообщение: супергруппа создана.</param>
/// <param name="ChannelChatCreated">Служебное сообщение: канал создан.</param>
/// <param name="MessageAutoDeleteTimerChanged">Служебное сообщение: изменены настройки автоудаления в чате.</param>
/// <param name="MigrateToChatId">Группа перенесена в супергруппу с указанным идентификатором.</param>
/// <param name="MigrateFromChatId">Супергруппа была перенесена из группы с указанным идентификатором.</param>
/// <param name="PinnedMessage">Указанное сообщение было закреплено.</param>
/// <param name="ProximityAlertTriggered">Служебное сообщение: пользователь в чате активировал оповещение о приближении другого пользователя.</param>
/// <param name="VideoChatScheduled">Служебное сообщение: видеочат запланирован.</param>
/// <param name="VideoChatEnded">Служебное сообщение: видеочат завершен.</param>
/// <param name="VideoChatParticipantsInvited">Служебное сообщение: новые участники приглашены в видеочат.</param>
/// <param name="ReplyMarkup">Встроенная клавиатура, прикрепленная к сообщению.</param>
public record Message(
    int MessageId,
    User? From,
    Chat? SenderChat,
    int Date,
    User? ForwardFrom,
    Chat Chat,
    Chat? ForwardFromChat,
    int? ForwardFromMessageId,
    string? ForwardSignature,
    string? ForwardSenderName,
    int? ForwardDate,
    bool? IsAutomaticForward,
    Message? ReplyToMessage,
    User? ViaBot,
    int? EditDate,
    bool? HasProtectedContent,
    string? MediaGroupId,
    string? AuthorSignature,
    string? Text,
    IEnumerable<MessageEntity>? Entities,
    Animation? Animation,
    Audio? Audio,
    Document? Document,
    IEnumerable<PhotoSize>? Photo,
    Video? Video,
    VideoNote? VideoNote,
    Voice? Voice,
    string? Caption,
    IEnumerable<MessageEntity>? CaptionEntities,
    Contact? Contact,
    Dice? Dice,
    Poll? Poll,
    Venue? Venue,
    Location? Location,
    IEnumerable<User>? NewChatMembers,
    User? LeftChatMember,
    string? NewChatTitle,
    IEnumerable<PhotoSize>? NewChatPhoto,
    bool? DeleteChatPhoto,
    bool? GroupChatCreated,
    bool? SupergroupChatCreated,
    bool? ChannelChatCreated,
    MessageAutoDeleteTimerChanged? MessageAutoDeleteTimerChanged,
    long? MigrateToChatId,
    int? MigrateFromChatId,
    Message? PinnedMessage,
    ProximityAlertTriggered? ProximityAlertTriggered,
    VideoChatScheduled? VideoChatScheduled,
    VideoChatEnded? VideoChatEnded,
    VideoChatParticipantsInvited? VideoChatParticipantsInvited,
    InlineKeyboardMarkup? ReplyMarkup);