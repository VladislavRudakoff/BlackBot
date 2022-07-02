using Telegram.Contracts.DTOs;
using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.DTOs.Chats.ChatMembers;
using Telegram.Contracts.DTOs.Commands;
using Telegram.Contracts.DTOs.Files;
using Telegram.Contracts.DTOs.Keyboard;
using Telegram.Contracts.DTOs.Menu;
using Telegram.Contracts.DTOs.Messages;
using Telegram.Contracts.Events;
using Telegram.Contracts.Events.BotCommands.Commands;
using Telegram.Contracts.Events.BotCommands.Queries;
using Telegram.Contracts.Events.Chats.Commands;
using Telegram.Contracts.Events.Chats.Commands.Buttons;
using Telegram.Contracts.Events.Chats.Commands.InviteLinks;
using Telegram.Contracts.Events.Chats.Commands.Messages;
using Telegram.Contracts.Events.Chats.Commands.Requests;
using Telegram.Contracts.Events.Chats.Commands.Stickers;
using Telegram.Contracts.Events.Chats.Commands.Users;
using Telegram.Contracts.Events.Chats.Queries;
using Telegram.Contracts.Events.Chats.Queries.Buttons;
using Telegram.Contracts.Events.Common.Commands.Contacts;
using Telegram.Contracts.Events.Common.Commands.Files;
using Telegram.Contracts.Events.Common.Commands.Files.Animations;
using Telegram.Contracts.Events.Common.Commands.Files.Audio;
using Telegram.Contracts.Events.Common.Commands.Files.Location;
using Telegram.Contracts.Events.Common.Commands.Files.Photos;
using Telegram.Contracts.Events.Common.Commands.Files.Video;
using Telegram.Contracts.Events.Common.Commands.Messages;
using Telegram.Contracts.Events.Common.Commands.Polls;
using Telegram.Contracts.Events.Common.Commands.Random;
using Telegram.Contracts.Events.Common.Queries.Files;

namespace Telegram.Contracts.ApiClients.Interfaces;

/// <summary>
/// Клиент Telegram API.
/// </summary>
public interface ITelegramClient
{
    /// <summary>
    /// Возвращает информацию о боте.
    /// </summary>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Информация о боте.</returns>
    Task<TelegramResponse<User>?> GetBotInfoAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Отправляет сообщение.
    /// </summary>
    /// <param name="sendMessage"><see cref="SendMessage"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Отправленное <b><see cref="Message"/>.</b></returns>
    Task<TelegramResponse<Message>?> SendMessageAsync(SendMessage sendMessage, CancellationToken cancellationToken = default);

    /// <summary>
    /// Пересылает сообщение.
    /// </summary>
    /// <param name="forwardMessage"><see cref="ForwardMessage"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Отправленное <b><see cref="Message"/>.</b></returns>
    Task<TelegramResponse<Message>?> ForwardMessageAsync(ForwardMessage forwardMessage, CancellationToken cancellationToken = default);

    /// <summary>
    /// Копирует сообщение.
    /// </summary>
    /// <param name="copyMessage"><see cref="CopyMessage"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Идентификатор отправленного <b><see cref="Message"/>.</b></returns>
    Task<TelegramResponse<MessageIdentifier>?> CopyMessageAsync(CopyMessage copyMessage, CancellationToken cancellationToken = default);

    /// <summary>
    /// Отправляет фотографию.
    /// </summary>
    /// <param name="sendPhoto"><see cref="SendPhoto"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Отправленное <b><see cref="Message"/>.</b></returns>
    Task<TelegramResponse<Message>?> SendPhotoAsync(SendPhoto sendPhoto, CancellationToken cancellationToken = default);

    /// <summary>
    /// Отправляет аудиофайл.<br />
    /// Файл должен быть в формате .MP3 или .M4A.<br />
    /// <b>Для отправки голосовых сообщений используется метод <see cref="SendVoiceAsync"/>.</b>
    /// </summary>
    /// <param name="sendAudio"><see cref="SendAudio"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Отправленное <b><see cref="Message"/>.</b></returns>
    Task<TelegramResponse<Message>?> SendAudioAsync(SendAudio sendAudio, CancellationToken cancellationToken = default);

    /// <summary>
    /// Отправляет общий файл.
    /// </summary>
    /// <param name="sendFile"><see cref="SendFile"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Отправленное <b><see cref="Message"/>.</b></returns>
    Task<TelegramResponse<Message>?> SendFileAsync(SendFile sendFile, CancellationToken cancellationToken = default);

    /// <summary>
    /// Отправляет видео в формате MPEG4(другие форматы могут быть отправлены с помощью <see cref="SendFile"/>).
    /// </summary>
    /// <param name="sendVideo"><see cref="SendVideo"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Отправленное <b><see cref="Message"/>.</b></returns>
    Task<TelegramResponse<Message>?> SendVideoAsync(SendVideo sendVideo, CancellationToken cancellationToken = default);

    /// <summary>
    /// Отправляет анимации(GIF или H.264/MPEG-4 AVC без звука).
    /// </summary>
    /// <param name="sendAnimation"><see cref="SendAnimation"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Отправленное <b><see cref="Message"/>.</b></returns>
    Task<TelegramResponse<Message>?> SendAnimationAsync(SendAnimation sendAnimation, CancellationToken cancellationToken = default);

    /// <summary>
    /// Отправляет голосовое сообщение(в формате .OGG, закодированном с помощью OPUS).<br />
    /// Другие форматы могут быть отправлены с помощью <b><see cref="SendAudio"/></b> или <b><see cref="SendFile"/>.</b> 
    /// </summary>
    /// <param name="sendVoice"><see cref="SendVoice"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Отправленное <b><see cref="Message"/>.</b></returns>
    Task<TelegramResponse<Message>?> SendVoiceAsync(SendVoice sendVoice, CancellationToken cancellationToken = default);

    /// <summary>
    /// Отправляет видеосообщение(в формате .MPEG4).
    /// </summary>
    /// <param name="sendVideoNote"><see cref="SendVideoNote"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Отправленное <b><see cref="Message"/>.</b></returns>
    Task<TelegramResponse<Message>?> SendVideoNoteAsync(SendVideoNote sendVideoNote, CancellationToken cancellationToken = default);

    /// <summary>
    /// Отправляет группу медиафайлов.
    /// </summary>
    /// <param name="sendMediaGroup"><see cref="SendMediaGroup"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Коллекция отправленных <b><see cref="Message"/>.</b></returns>
    Task<TelegramResponse<IEnumerable<Message>>?> SendMediaGroupAsync(SendMediaGroup sendMediaGroup, CancellationToken cancellationToken = default);

    /// <summary>
    /// Отправляет местоположение.
    /// </summary>
    /// <param name="sendLocation"><see cref="SendLocation"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Отправленное <b><see cref="Message"/>.</b></returns>
    Task<TelegramResponse<Message>?> SendLocationAsync(SendLocation sendLocation, CancellationToken cancellationToken = default);

    //TODO: Разобраться с Inline аналогом метода. 
    /// <summary>
    /// Редактирует сообщение о текущем местоположении.<br />
    /// Местоположение можно редактировать до истечения срока действия или пока не вызван метод <b><see cref="StopLiveLocationAsync"/></b>
    /// </summary>
    /// <param name="editLiveLocation"><see cref="EditMessageLiveLocation"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Отредактированное <b><see cref="Message"/>.</b></returns>
    Task<TelegramResponse<Message>?> EditLiveLocationAsync(EditMessageLiveLocation editLiveLocation, CancellationToken cancellationToken = default);

    //TODO: Разобраться с Inline аналогом метода. 
    /// <summary>
    /// Останавливает обновление сообщение о текущем местоположении.
    /// </summary>
    /// <param name="stopLiveLocation"><see cref="StopMessageLiveLocation"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Отредактированное <b><see cref="Message"/>.</b></returns>
    Task<TelegramResponse<Message>?> StopLiveLocationAsync(StopMessageLiveLocation stopLiveLocation, CancellationToken cancellationToken = default);

    /// <summary>
    /// Отправляет информацию о месте проведения.
    /// </summary>
    /// <param name="sendVenue"><see cref="SendVenue"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Отправленное <b><see cref="Message"/>.</b></returns>
    Task<TelegramResponse<Message>?> SendVenueAsync(SendVenue sendVenue, CancellationToken cancellationToken = default);

    /// <summary>
    /// Отправляет информацию о месте проведения.
    /// </summary>
    /// <param name="sendContact"><see cref="SendContact"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Отправленное <b><see cref="Message"/>.</b></returns>
    Task<TelegramResponse<Message>?> SendContactAsync(SendContact sendContact, CancellationToken cancellationToken = default);

    /// <summary>
    /// Отправляет опрос.
    /// </summary>
    /// <param name="sendPool"><see cref="SendPoll"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Отправленное <b><see cref="Message"/>.</b></returns>
    Task<TelegramResponse<Message>?> SendPollAsync(SendPoll sendPool, CancellationToken cancellationToken = default);

    /// <summary>
    /// Отправляет emoji со случайным значением.
    /// </summary>
    /// <param name="sendDice"><see cref="SendDice"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Отправленное <b><see cref="Message"/>.</b></returns>
    Task<TelegramResponse<Message>?> SendDiceAsync(SendDice sendDice, CancellationToken cancellationToken = default);

    /// <summary>
    /// Получает основную информацию о файле и готовит его к загрузке(до 20Мб).<br />
    /// Файл потом можно скачать по ссылке <b>https://api.telegram.org/file/bot{token}/{file_path}</b>, где <b>{file_path}</b> - FilePath из полученной модели. 
    /// </summary>
    /// <param name="getFile"><see cref="GetFile"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b><see cref="FileForDownload"/>.</b></returns>
    Task<TelegramResponse<FileForDownload>?> GetFileAsync(GetFile getFile, CancellationToken cancellationToken = default);

    //TODO Всё что ниже этой строчки - ещё пока не тестировал, отложил на время.
    //  |
    //  |
    //  V

    /// <summary>
    /// Блокирует пользователя в группе, супергруппе или канале. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="banChatMember"><see cref="BanChatMember"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><see cref="bool"/>.</returns>
    Task<TelegramResponse<bool>?> BanChatMemberAsync(BanChatMember banChatMember, CancellationToken cancellationToken = default);

    /// <summary>
    /// Разблокирует пользователя. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="unbanChatMember"><see cref="UnbanChatMember"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><see cref="bool"/>.</returns>
    Task<TelegramResponse<bool>?> UnbanChatMemberAsync(UnbanChatMember unbanChatMember, CancellationToken cancellationToken = default);

    /// <summary>
    /// Ограничивает разрешения пользователя в чате. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="restrictChatMember"><see cref="RestrictChatMember"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><see cref="bool"/>.</returns>
    Task<TelegramResponse<bool>?> RestrictChatMemberAsync(RestrictChatMember restrictChatMember, CancellationToken cancellationToken = default);

    /// <summary>
    /// Повышает/понижает пользователя в супергруппе или канале. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="promoteChatMember"><see cref="PromoteChatMember"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><see cref="bool"/>.</returns>
    Task<TelegramResponse<bool>?> PromoteChatMemberAsync(PromoteChatMember promoteChatMember, CancellationToken cancellationToken = default);

    /// <summary>
    /// Задаёт "титул" для администратора в супергруппе.
    /// </summary>
    /// <param name="setChatAdministratorTitle"><see cref="SetChatAdministratorTitle"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><see cref="bool"/>.</returns>
    Task<TelegramResponse<bool>?> SetChatAdministratorCustomTitleAsync(SetChatAdministratorTitle setChatAdministratorTitle, CancellationToken cancellationToken = default);

    /// <summary>
    /// Блокирует чат канала в супергруппе или на канале. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="banChatSenderChat"><see cref="BanChatSenderChat"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><see cref="bool"/>.</returns>
    Task<TelegramResponse<bool>?> BanChatSenderChatAsync(BanChatSenderChat banChatSenderChat, CancellationToken cancellationToken = default);

    /// <summary>
    /// Разблокирует чат канала в супергруппе или на канале. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="unbanChatSenderChat"><see cref="UnbanChatSenderChat"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><see cref="bool"/>.</returns>
    Task<TelegramResponse<bool>?> UnbanChatSenderChatAsync(UnbanChatSenderChat unbanChatSenderChat, CancellationToken cancellationToken = default);

    /// <summary>
    /// Устанавливает разрешения чата по умолчанию. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="setDefaultChatPermissions"><see cref="SetDefaultChatPermissions"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><see cref="bool"/>.</returns>
    Task<TelegramResponse<bool>?> SetDefaultChatPermissionsAsync(SetDefaultChatPermissions setDefaultChatPermissions, CancellationToken cancellationToken = default);

    /// <summary>
    /// Создаёт основную ссылку-приглашение в чат. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="exportChatInviteLink"><see cref="ExportChatInviteLink"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>Ссылка-приглашение.</b></returns>
    Task<TelegramResponse<string>?> ExportChatInviteLinkAsync(ExportChatInviteLink exportChatInviteLink, CancellationToken cancellationToken = default);

    /// <summary>
    /// Создаёт дополнительную ссылку-приглашение в чат. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="createChatInviteLink"><see cref="CreateChatInviteLink"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b><see cref="ChatInviteLink"/>.</b></returns>
    Task<TelegramResponse<ChatInviteLink>?> CreateChatInviteLinkAsync(CreateChatInviteLink createChatInviteLink, CancellationToken cancellationToken = default);

    /// <summary>
    /// Редактирует дополнительную ссылку-приглашение в чат. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="editChatInviteLink"><see cref="EditChatInviteLink"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b><see cref="ChatInviteLink"/>.</b></returns>
    Task<TelegramResponse<ChatInviteLink>?> EditChatInviteLinkAsync(EditChatInviteLink editChatInviteLink, CancellationToken cancellationToken = default);

    /// <summary>
    /// Отзывает ссылку-приглашение в чат. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="revokeChatInviteLink"><see cref="RevokeChatInviteLink"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b><see cref="ChatInviteLink"/>.</b></returns>
    Task<TelegramResponse<ChatInviteLink>?> RevokeChatInviteLinkAsync(RevokeChatInviteLink revokeChatInviteLink, CancellationToken cancellationToken = default);

    /// <summary>
    /// Отзывает ссылку-приглашение в чат. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="approveChatJoinRequest"><see cref="ApproveChatJoinRequest"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>True - в случае успеха.</b></returns>
    Task<TelegramResponse<bool>?> ApproveChatJoinRequestAsync(ApproveChatJoinRequest approveChatJoinRequest, CancellationToken cancellationToken = default);

    /// <summary>
    /// Отзывает ссылку-приглашение в чат. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="declineChatJoinRequest"><see cref="DeclineChatJoinRequest"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>True - в случае успеха.</b></returns>
    Task<TelegramResponse<bool>?> DeclineChatJoinRequestAsync(DeclineChatJoinRequest declineChatJoinRequest, CancellationToken cancellationToken = default);

    /// <summary>
    /// Удаляет фотографию чата. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="deleteChatPhoto"><see cref="DeleteChatPhoto"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>True - в случае успеха.</b></returns>
    Task<TelegramResponse<bool>?> DeleteChatPhotoAsync(DeleteChatPhoto deleteChatPhoto, CancellationToken cancellationToken = default);

    /// <summary>
    /// Изменяет название чата. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="setChatTitle"><see cref="SetChatTitle"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>True - в случае успеха.</b></returns>
    Task<TelegramResponse<bool>?> SetChatTitleAsync(SetChatTitle setChatTitle, CancellationToken cancellationToken = default);

    /// <summary>
    /// Изменяет описание чата, супергруппы или канала. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="setChatDescription"><see cref="SetChatDescription"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>True - в случае успеха.</b></returns>
    Task<TelegramResponse<bool>?> SetChatDescriptionAsync(SetChatDescription setChatDescription, CancellationToken cancellationToken = default);

    /// <summary>
    /// Удаляет сообщение из списка закрепленных. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="unpinChatMessage"><see cref="UnpinChatMessage"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>True - в случае успеха.</b></returns>
    Task<TelegramResponse<bool>?> UnpinChatMessageAsync(UnpinChatMessage unpinChatMessage, CancellationToken cancellationToken = default);

    /// <summary>
    /// Добавляет сообщение в список закрепленных. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="pinChatMessage"><see cref="PinChatMessage"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>True - в случае успеха.</b></returns>
    Task<TelegramResponse<bool>?> PinChatMessageAsync(PinChatMessage pinChatMessage, CancellationToken cancellationToken = default);

    /// <summary>
    /// Удаляет все сообщения из списка закрепленных. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="unpinAllChatMessages"><see cref="UnpinAllChatMessages"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>True - в случае успеха.</b></returns>
    Task<TelegramResponse<bool>?> UnpinAllChatMessagesAsync(UnpinAllChatMessages unpinAllChatMessages, CancellationToken cancellationToken = default);

    /// <summary>
    /// Заставляет бота покинуть группу, супергруппу или канал.
    /// </summary>
    /// <param name="leaveChat"><see cref="LeaveChat"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>True - в случае успеха.</b></returns>
    Task<TelegramResponse<bool>?> LeaveChatAsync(LeaveChat leaveChat, CancellationToken cancellationToken = default);

    /// <summary>
    /// Получает всю доступную информацию о чате.
    /// </summary>
    /// <param name="getChat"><see cref="GetChat"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b><see cref="Chat"/>.</b></returns>
    Task<TelegramResponse<Chat>?> GetChatAsync(GetChat getChat, CancellationToken cancellationToken = default);

    /// <summary>
    /// Получает список администраторов чата(кроме других ботов). Если чат является группой или супергруппой без администраторов, в коллекции будет только создатель.
    /// </summary>
    /// <param name="getChatAdministrators"><see cref="GetChatAdministrators"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>Коллекция <see cref="ChatMember"/>.</b></returns>
    Task<TelegramResponse<IEnumerable<ChatMember>>?> GetChatAdministratorsAsync(GetChatAdministrators getChatAdministrators, CancellationToken cancellationToken = default);

    /// <summary>
    /// Получает количество участников чата.
    /// </summary>
    /// <param name="getChatMemberCount"><see cref="GetChatMemberCount"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>Количество участников.</b></returns>
    Task<TelegramResponse<int>?> GetChatMemberCountAsync(GetChatMemberCount getChatMemberCount, CancellationToken cancellationToken = default);

    /// <summary>
    /// Получает информацию об участнике чата.
    /// </summary>
    /// <param name="getChatMember"><see cref="GetChatMember"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b><see cref="ChatMember"/>.</b></returns>
    Task<TelegramResponse<ChatMember>?> GetChatMemberAsync(GetChatMember getChatMember, CancellationToken cancellationToken = default);

    /// <summary>
    /// Создаёт коллекцию стикеров. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="setChatStickerSet"><see cref="SetChatStickerSet"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>True - в случае успеха.</b></returns>
    Task<TelegramResponse<bool>?> SetChatStickerSetAsync(SetChatStickerSet setChatStickerSet, CancellationToken cancellationToken = default);

    /// <summary>
    /// Удаляет коллекцию стикеров. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="deleteChatStickerSet"><see cref="DeleteChatStickerSet"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>True - в случае успеха.</b></returns>
    Task<TelegramResponse<bool>?> DeleteChatStickerSetAsync(DeleteChatStickerSet deleteChatStickerSet, CancellationToken cancellationToken = default);

    /// <summary>
    /// Отправляет ответ на <see cref="CallbackQuery"/>. Ответ отобразится в виде уведомления в верхней части экрана, либо в виде предупреждения.
    /// </summary>
    /// <param name="answerCallbackQuery"><see cref="AnswerCallbackQuery"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>True - в случае успеха.</b></returns>
    Task<TelegramResponse<bool>?> AnswerCallbackQueryAsync(AnswerCallbackQuery answerCallbackQuery, CancellationToken cancellationToken = default);

    /// <summary>
    /// Устанавливает список команд бота.
    /// </summary>
    /// <param name="setMyCommands"><see cref="SetMyCommands"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>True - в случае успеха.</b></returns>
    Task<TelegramResponse<bool>?> SetCommandsAsync(SetMyCommands setMyCommands, CancellationToken cancellationToken = default);

    /// <summary>
    /// Удаляет список команд бота для данной области и языка пользователя. После удаления, затронутым пользователям будут показаны команды более высокого уровня.
    /// </summary>
    /// <param name="deleteMyCommands"><see cref="DeleteMyCommands"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>True - в случае успеха.</b></returns>
    Task<TelegramResponse<bool>?> DeleteCommandsAsync(DeleteMyCommands deleteMyCommands, CancellationToken cancellationToken = default);

    /// <summary>
    /// Получает коллекцию команд бота.
    /// </summary>
    /// <param name="getMyCommands"><see cref="GetMyCommands"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>Коллекция <see cref="BotCommand"/>.</b></returns>
    Task<TelegramResponse<IEnumerable<BotCommand>>?> GetCommandsAsync(GetMyCommands getMyCommands, CancellationToken cancellationToken = default);

    /// <summary>
    /// Изменяет кнопку меню бота в приватном чате или кнопку меню по умолчанию.
    /// </summary>
    /// <param name="setChatMenuButton"><see cref="SetChatMenuButton"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>True - в случае успеха.</b></returns>
    Task<TelegramResponse<bool>?> SetChatMenuButtonAsync(SetChatMenuButton setChatMenuButton, CancellationToken cancellationToken = default);

    /// <summary>
    /// Получает текущее значение кнопки меню бота в приватном чате или кнопку меню по умолчанию.
    /// </summary>
    /// <param name="getChatMenuButton"><see cref="GetChatMenuButton"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b><see cref="MenuButton"/>.</b></returns>
    Task<TelegramResponse<MenuButton>?> GetChatMenuButtonAsync(GetChatMenuButton getChatMenuButton, CancellationToken cancellationToken = default);
}