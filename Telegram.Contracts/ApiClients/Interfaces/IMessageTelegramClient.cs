using Telegram.Contracts.DTOs;
using Telegram.Contracts.DTOs.Files;
using Telegram.Contracts.DTOs.Keyboard;
using Telegram.Contracts.DTOs.Messages;
using Telegram.Contracts.DTOs.Pools;
using Telegram.Contracts.DTOs.Stickers;
using Telegram.Contracts.Events;
using Telegram.Contracts.Events.Chats.Commands.Messages;
using Telegram.Contracts.Events.Chats.Commands.Stickers;
using Telegram.Contracts.Events.Chats.Queries.Stickers;
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
/// Клиент Telegram Api с методами для сообщений.
/// </summary>
public interface IMessageTelegramClient
{
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
    /// Останавливает опрос.
    /// </summary>
    /// <param name="stopPoll"><see cref="StopPoll"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Остановленный <b><see cref="Poll"/>.</b></returns>
    Task<TelegramResponse<Poll>?> StopPollAsync(StopPoll stopPoll, CancellationToken cancellationToken = default);

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

    /// <summary>
    /// Добавляет сообщение в список закрепленных. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="pinChatMessage"><see cref="PinChatMessage"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>True - в случае успеха.</b></returns>
    Task<TelegramResponse<bool>?> PinChatMessageAsync(PinChatMessage pinChatMessage, CancellationToken cancellationToken = default);

    /// <summary>
    /// Удаляет сообщение из списка закрепленных. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="unpinChatMessage"><see cref="UnpinChatMessage"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>True - в случае успеха.</b></returns>
    Task<TelegramResponse<bool>?> UnpinChatMessageAsync(UnpinChatMessage unpinChatMessage, CancellationToken cancellationToken = default);

    /// <summary>
    /// Удаляет все сообщения из списка закрепленных. Бот должен быть администратором с соответствующими правами.
    /// </summary>
    /// <param name="unpinAllChatMessages"><see cref="UnpinAllChatMessages"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>True - в случае успеха.</b></returns>
    Task<TelegramResponse<bool>?> UnpinAllChatMessagesAsync(UnpinAllChatMessages unpinAllChatMessages, CancellationToken cancellationToken = default);

    /// <summary>
    /// Отправляет ответ на <see cref="CallbackQuery"/>. Ответ отобразится в виде уведомления в верхней части экрана, либо в виде предупреждения.
    /// </summary>
    /// <param name="answerCallbackQuery"><see cref="AnswerCallbackQuery"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>True - в случае успеха.</b></returns>
    Task<TelegramResponse<bool>?> AnswerCallbackQueryAsync(AnswerCallbackQuery answerCallbackQuery, CancellationToken cancellationToken = default);

    //TODO: Разобраться с inline-вариантом нижестоящих методов.
    //  |
    //  |
    //  |
    //  V

    /// <summary>
    /// Редактирует текстовые и игровые сообщения.
    /// </summary>
    /// <param name="editMessageText"><see cref="EditMessageText"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Отредактированное <b><see cref="Message"/>.</b></returns>
    Task<TelegramResponse<Message>?> EditMessageTextAsync(EditMessageText editMessageText, CancellationToken cancellationToken = default);

    /// <summary>
    /// Редактирует заголовок сообщения.
    /// </summary>
    /// <param name="editMessageCaption"><see cref="EditMessageCaption"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Отредактированное <b><see cref="Message"/>.</b></returns>
    Task<TelegramResponse<Message>?> EditMessageCaptionAsync(EditMessageCaption editMessageCaption, CancellationToken cancellationToken = default);

    /// <summary>
    /// Редактирует анимацию, аудио, документы, фото или видео сообщения.
    /// </summary>
    /// <remarks>Если сообщение является частью альбома, то его можно изменить только на аналогичный тип сообщения(фото только на фото, видео на видео и т.д.).</remarks>
    /// <param name="editMessageMedia"><see cref="EditMessageMedia"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Отредактированное <b><see cref="Message"/>.</b></returns>
    Task<TelegramResponse<Message>?> EditMessageMediaAsync(EditMessageMedia editMessageMedia, CancellationToken cancellationToken = default);

    /// <summary>
    /// Редактирует разметку сообщений.
    /// </summary>
    /// <param name="editMessageReplyMarkup"><see cref="EditMessageReplyMarkup"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Отредактированное <b><see cref="Message"/>.</b></returns>
    Task<TelegramResponse<Message>?> EditMessageReplyMarkupAsync(EditMessageReplyMarkup editMessageReplyMarkup, CancellationToken cancellationToken = default);

    //  Ʌ
    //  |
    //  |
    //  |
    //TODO: Разобраться с inline-вариантом вышестоящих методов.

    /// <summary>
    /// Удаляет сообщение.
    /// </summary>
    /// <remarks>
    /// - Сообщение может быть удалено только в том случае, если оно было отправлено менее 48 часов назад. <br />
    /// - Сообщение с кубиками в приватном чате можно удалить только в том случае, если оно было отправлено более 24 часов назад <br />
    /// - Боты могут удалять исходящие сообщения в приватных чатах, группах и супергруппах. <br />
    /// - Боты могут удалять входящие сообщения в приватных чатах. <br />
    /// - Боты с разрешениями CanPostMessages могут удалять исходящие сообщения в каналах. <br />
    /// - Если бот является администратором группы, он может удалить там любое сообщение. <br />
    /// - Если у бота есть разрешение CanDeleteMessages в супергруппе или канале, он может удалить там любое сообщение.
    /// </remarks>
    /// <param name="deleteMessage"><see cref="DeleteMessage"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b>True - в случае успеха.</b></returns>
    Task<TelegramResponse<Message>?> EditMessageReplyMarkupAsync(DeleteMessage deleteMessage, CancellationToken cancellationToken = default);

    /// <summary>
    /// Отправляет статические стикеры(.WEBP), анимированные(.TGS) или видеостикеры(.WEBM).
    /// </summary>
    /// <param name="sendSticker"><see cref="SendSticker"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Отправленное <b><see cref="Message"/>.</b></returns>
    Task<TelegramResponse<Message>?> SendStickerAsync(SendSticker sendSticker, CancellationToken cancellationToken = default);

    /// <summary>
    /// Получает набор стикеров.
    /// </summary>
    /// <param name="getStickerSet"><see cref="GetStickerSet"/>.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><b><see cref="StickerSet"/>.</b></returns>
    Task<TelegramResponse<StickerSet>?> GetStickerSetAsync(GetStickerSet getStickerSet, CancellationToken cancellationToken = default);
}