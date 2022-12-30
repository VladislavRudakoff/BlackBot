using Telegram.Contracts.ApiClients.Interfaces;
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
using Telegram.Contracts.Settings;

namespace Telegram.Contracts.ApiClients;

public class MessageTelegramClient : BaseTelegramClient, IMessageTelegramClient
{
    /// <summary>
    /// ctor.
    /// </summary>
    /// <param name="httpClient"><see cref="HttpClient"/>.</param>
    /// <param name="telegramClientSettings">Настройки telegram-клиента.</param>
    public MessageTelegramClient(
        HttpClient httpClient,
        TelegramClientSettings telegramClientSettings)
        : base(httpClient, telegramClientSettings)
    {
    }

    public async Task<TelegramResponse<Message>?> SendMessageAsync(SendMessage sendMessage, CancellationToken cancellationToken = default) =>
    await ExecuteCommand<SendMessage, Message>(sendMessage, "/sendMessage", cancellationToken);

    public async Task<TelegramResponse<Message>?> ForwardMessageAsync(ForwardMessage forwardMessage, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<ForwardMessage, Message>(forwardMessage, "/forwardMessage", cancellationToken);

    public async Task<TelegramResponse<MessageIdentifier>?> CopyMessageAsync(CopyMessage copyMessage, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<CopyMessage, MessageIdentifier>(copyMessage, "/copyMessage", cancellationToken);

    public async Task<TelegramResponse<Message>?> SendPhotoAsync(SendPhoto sendPhoto, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendPhoto, Message>(sendPhoto, "/sendPhoto", cancellationToken);

    public async Task<TelegramResponse<Message>?> SendAudioAsync(SendAudio sendAudio, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendAudio, Message>(sendAudio, "/sendAudio", cancellationToken);

    public async Task<TelegramResponse<Message>?> SendFileAsync(SendFile sendFile, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendFile, Message>(sendFile, "/sendDocument", cancellationToken);

    public async Task<TelegramResponse<Message>?> SendVideoAsync(SendVideo sendVideo, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendVideo, Message>(sendVideo, "/sendVideo", cancellationToken);

    public async Task<TelegramResponse<Message>?> SendAnimationAsync(SendAnimation sendAnimation, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendAnimation, Message>(sendAnimation, "/sendAnimation", cancellationToken);

    public async Task<TelegramResponse<Message>?> SendVoiceAsync(SendVoice sendVoice, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendVoice, Message>(sendVoice, "/sendVoice", cancellationToken);

    public async Task<TelegramResponse<Message>?> SendVideoNoteAsync(SendVideoNote sendVideoNote, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendVideoNote, Message>(sendVideoNote, "/sendVideoNote", cancellationToken);

    public async Task<TelegramResponse<IEnumerable<Message>>?> SendMediaGroupAsync(SendMediaGroup sendMediaGroup, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendMediaGroup, IEnumerable<Message>>(sendMediaGroup, "/sendMediaGroup", cancellationToken);

    public async Task<TelegramResponse<Message>?> SendLocationAsync(SendLocation sendLocation, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendLocation, Message>(sendLocation, "/sendLocation", cancellationToken);

    public async Task<TelegramResponse<Message>?> EditLiveLocationAsync(EditMessageLiveLocation editLiveLocation, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<EditMessageLiveLocation, Message>(editLiveLocation, "/editMessageLiveLocation", cancellationToken);

    public async Task<TelegramResponse<Message>?> StopLiveLocationAsync(StopMessageLiveLocation stopLiveLocation, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<StopMessageLiveLocation, Message>(stopLiveLocation, "/stopMessageLiveLocation", cancellationToken);

    public async Task<TelegramResponse<Message>?> SendVenueAsync(SendVenue sendVenue, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendVenue, Message>(sendVenue, "/sendVenue", cancellationToken);

    public async Task<TelegramResponse<Message>?> SendContactAsync(SendContact sendContact, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendContact, Message>(sendContact, "/sendContact", cancellationToken);

    public async Task<TelegramResponse<Message>?> SendPollAsync(SendPoll sendPool, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendPoll, Message>(sendPool, "/sendPoll", cancellationToken);

    public async Task<TelegramResponse<Poll>?> StopPollAsync(StopPoll stopPoll, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<StopPoll, Poll>(stopPoll, "/stopPoll", cancellationToken);

    public async Task<TelegramResponse<Message>?> SendDiceAsync(SendDice sendDice, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendDice, Message>(sendDice, "/sendDice", cancellationToken);

    public async Task<TelegramResponse<bool>?> UnpinChatMessageAsync(UnpinChatMessage unpinChatMessage, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<UnpinChatMessage, bool>(unpinChatMessage, "/unpinChatMessage", cancellationToken);

    public async Task<TelegramResponse<bool>?> PinChatMessageAsync(PinChatMessage pinChatMessage, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<PinChatMessage, bool>(pinChatMessage, "/pinChatMessage", cancellationToken);

    public async Task<TelegramResponse<bool>?> UnpinAllChatMessagesAsync(UnpinAllChatMessages unpinAllChatMessages, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<UnpinAllChatMessages, bool>(unpinAllChatMessages, "/unpinAllChatMessages", cancellationToken);

    public async Task<TelegramResponse<FileForDownload>?> GetFileAsync(GetFile getFile, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<GetFile, FileForDownload>(getFile, "/getFile", cancellationToken);

    public async Task<TelegramResponse<bool>?> AnswerCallbackQueryAsync(AnswerCallbackQuery answerCallbackQuery, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<AnswerCallbackQuery, bool>(answerCallbackQuery, "/answerCallbackQuery", cancellationToken);

    public async Task<TelegramResponse<Message>?> EditMessageTextAsync(EditMessageText editMessageText, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<EditMessageText, Message>(editMessageText, "/editMessageText", cancellationToken);

    public async Task<TelegramResponse<Message>?> EditMessageCaptionAsync(EditMessageCaption editMessageCaption, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<EditMessageCaption, Message>(editMessageCaption, "/editMessageCaption", cancellationToken);

    public async Task<TelegramResponse<Message>?> EditMessageMediaAsync(EditMessageMedia editMessageMedia, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<EditMessageMedia, Message>(editMessageMedia, "/editMessageMedia", cancellationToken);

    public async Task<TelegramResponse<Message>?> EditMessageReplyMarkupAsync(EditMessageReplyMarkup editMessageReplyMarkup, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<EditMessageReplyMarkup, Message>(editMessageReplyMarkup, "/editMessageReplyMarkup", cancellationToken);

    public async Task<TelegramResponse<Message>?> EditMessageReplyMarkupAsync(DeleteMessage deleteMessage, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<DeleteMessage, Message>(deleteMessage, "/deleteMessage", cancellationToken);

    public async Task<TelegramResponse<Message>?> SendStickerAsync(SendSticker sendSticker, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendSticker, Message>(sendSticker, "/sendSticker", cancellationToken);

    public async Task<TelegramResponse<StickerSet>?> GetStickerSetAsync(GetStickerSet getStickerSet, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<GetStickerSet, StickerSet>(getStickerSet, "/getStickerSet", cancellationToken);

    public async Task<TelegramResponse<bool>?> SetStickerSetThumbAsync(SetStickerSetThumb setStickerSetThumb, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SetStickerSetThumb, bool>(setStickerSetThumb, "/setStickerSetThumb", cancellationToken);

    public async Task<TelegramResponse<bool>?> DeleteStickerFromSetAsync(DeleteStickerFromSet deleteStickerFromSet, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<DeleteStickerFromSet, bool>(deleteStickerFromSet, "/deleteStickerFromSet", cancellationToken);

    public async Task<TelegramResponse<bool>?> SetStickerPositionInSetAsync(SetStickerPositionInSet setStickerPositionInSet, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SetStickerPositionInSet, bool>(setStickerPositionInSet, "/setStickerPositionInSet", cancellationToken);
}