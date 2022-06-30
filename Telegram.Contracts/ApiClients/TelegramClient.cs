using Bot.Common.Extensions;
using Telegram.Contracts.ApiClients.Interfaces;
using Telegram.Contracts.DTOs;
using Telegram.Contracts.DTOs.Messages;
using Telegram.Contracts.Events.Common.Contacts;
using Telegram.Contracts.Events.Common.Files;
using Telegram.Contracts.Events.Common.Files.Animations;
using Telegram.Contracts.Events.Common.Files.Audio;
using Telegram.Contracts.Events.Common.Files.Location;
using Telegram.Contracts.Events.Common.Files.Photos;
using Telegram.Contracts.Events.Common.Files.Video;
using Telegram.Contracts.Events.Common.Interfaces;
using Telegram.Contracts.Events.Common.Messages;
using Telegram.Contracts.Events.Common.Polls;
using Telegram.Contracts.Events.Common.Random;
using Telegram.Contracts.Settings;

namespace Telegram.Contracts.ApiClients;

/// <inheritdoc />
public class TelegramClient : ITelegramClient
{
    private readonly HttpClient httpClient;
    private readonly TelegramClientSettings telegramClientSettings;

    private readonly string baseBotUrl;

    /// <summary>
    /// ctor.
    /// </summary>
    /// <param name="httpClient"><see cref="HttpClient"/>.</param>
    /// <param name="telegramClientSettings">Настройки telegram-клиента.</param>
    public TelegramClient(
        HttpClient httpClient,
        TelegramClientSettings telegramClientSettings)
    {
        this.httpClient = httpClient;
        this.telegramClientSettings = telegramClientSettings;

        baseBotUrl = telegramClientSettings.BaseUrl + telegramClientSettings.Token;
    }

    /// <inheritdoc />
    public async Task<TelegramResponse<User>?> GetBotInfoAsync(CancellationToken cancellationToken = default) =>
        await httpClient.GetAsJsonAsync<TelegramResponse<User>>(baseBotUrl + "/getMe", cancellationToken);

    /// <inheritdoc />
    public async Task<TelegramResponse<Message>?> SendMessageAsync(SendMessage sendMessage, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendMessage, Message>(sendMessage, "/sendMessage", cancellationToken);

    /// <inheritdoc />
    public async Task<TelegramResponse<Message>?> ForwardMessageAsync(ForwardMessage forwardMessage, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<ForwardMessage, Message>(forwardMessage, "/forwardMessage", cancellationToken);

    /// <inheritdoc />
    public async Task<TelegramResponse<MessageIdentifier>?> CopyMessageAsync(CopyMessage copyMessage, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<CopyMessage, MessageIdentifier>(copyMessage, "/copyMessage", cancellationToken);
    
    /// <inheritdoc />
    public async Task<TelegramResponse<Message>?> SendPhotoAsync(SendPhoto sendPhoto, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendPhoto, Message>(sendPhoto, "/sendPhoto", cancellationToken);

    /// <inheritdoc />
    public async Task<TelegramResponse<Message>?> SendAudioAsync(SendAudio sendAudio, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendAudio, Message>(sendAudio, "/sendAudio", cancellationToken);

    /// <inheritdoc />
    public async Task<TelegramResponse<Message>?> SendFileAsync(SendFile sendFile, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendFile, Message>(sendFile, "/sendDocument", cancellationToken);

    /// <inheritdoc />
    public async Task<TelegramResponse<Message>?> SendVideoAsync(SendVideo sendVideo, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendVideo, Message>(sendVideo, "/sendVideo", cancellationToken);

    /// <inheritdoc />
    public async Task<TelegramResponse<Message>?> SendAnimationAsync(SendAnimation sendAnimation, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendAnimation, Message>(sendAnimation, "/sendAnimation", cancellationToken);

    /// <inheritdoc />
    public async Task<TelegramResponse<Message>?> SendVoiceAsync(SendVoice sendVoice, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendVoice, Message>(sendVoice, "/sendVoice", cancellationToken);

    /// <inheritdoc />
    public async Task<TelegramResponse<Message>?> SendVideoNoteAsync(SendVideoNote sendVideoNote, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendVideoNote, Message>(sendVideoNote, "/sendVideoNote", cancellationToken);

    /// <inheritdoc />
    public async Task<TelegramResponse<IEnumerable<Message>>?> SendMediaGroupAsync(SendMediaGroup sendMediaGroup, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendMediaGroup, IEnumerable<Message>>(sendMediaGroup, "/sendMediaGroup", cancellationToken);

    /// <inheritdoc />
    public async Task<TelegramResponse<Message>?> SendLocationAsync(SendLocation sendLocation, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendLocation, Message>(sendLocation, "/sendLocation", cancellationToken);

    /// <inheritdoc />
    public async Task<TelegramResponse<Message>?> EditLiveLocationAsync(EditMessageLiveLocation editLiveLocation, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<EditMessageLiveLocation, Message>(editLiveLocation, "/editMessageLiveLocation", cancellationToken);

    /// <inheritdoc />
    public async Task<TelegramResponse<Message>?> StopLiveLocationAsync(StopMessageLiveLocation stopLiveLocation, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<StopMessageLiveLocation, Message>(stopLiveLocation, "/stopMessageLiveLocation", cancellationToken);

    /// <inheritdoc />
    public async Task<TelegramResponse<Message>?> SendVenueAsync(SendVenue sendVenue, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendVenue, Message>(sendVenue, "/sendVenue", cancellationToken);

    /// <inheritdoc />
    public async Task<TelegramResponse<Message>?> SendContactAsync(SendContact sendContact, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendContact, Message>(sendContact, "/sendContact", cancellationToken);

    /// <inheritdoc />
    public async Task<TelegramResponse<Message>?> SendPollAsync(SendPoll sendPool, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendPoll, Message>(sendPool, "/sendPoll", cancellationToken);

    /// <inheritdoc />
    public async Task<TelegramResponse<Message>?> SendDiceAsync(SendDice sendDice, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendDice, Message>(sendDice, "/sendDice", cancellationToken);

    private async Task<TelegramResponse<TU>?> ExecuteCommand<T, TU>(
        T commandModel, 
        string command, 
        CancellationToken cancellationToken = default) 
        where T: IEventEntity =>
        await httpClient.PostAsJsonAsync<TelegramResponse<TU>?>(
            baseBotUrl + command,
            commandModel,
            cancellationToken);
}