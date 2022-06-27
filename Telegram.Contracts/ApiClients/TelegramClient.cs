using Bot.Common.Extensions;
using Telegram.Contracts.DTOs;
using Telegram.Contracts.DTOs.Messages;
using Telegram.Contracts.Events.Files;
using Telegram.Contracts.Events.Files.Animations;
using Telegram.Contracts.Events.Files.Audio;
using Telegram.Contracts.Events.Files.Photos;
using Telegram.Contracts.Events.Files.Video;
using Telegram.Contracts.Events.Interfaces;
using Telegram.Contracts.Events.Messages;
using Telegram.Contracts.Settings;

namespace Telegram.Contracts.ApiClients;

public class TelegramClient : BaseTelegramClient
{
    /// <summary>
    /// ctor.
    /// </summary>
    /// <param name="httpClient"><see cref="HttpClient"/>.</param>
    /// <param name="telegramClientSettings">Настройки telegram-клиента.</param>
    public TelegramClient(
        HttpClient httpClient,
        TelegramClientSettings telegramClientSettings)
        : base(httpClient, telegramClientSettings)
    {
    }

    /// <inheritdoc />
    public override async Task<TelegramResponse<User>?> GetBotInfoAsync(CancellationToken cancellationToken = default) =>
        await HttpClient.GetAsJsonAsync<TelegramResponse<User>>(BaseBotUrl + "/getMe", cancellationToken);

    /// <inheritdoc />
    public override async Task<TelegramResponse<Message>?> SendMessageAsync(SendMessage sendMessage, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendMessage, Message>(sendMessage, "/sendMessage", cancellationToken);

    /// <inheritdoc />
    public override async Task<TelegramResponse<Message>?> ForwardMessageAsync(ForwardMessage forwardMessage, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<ForwardMessage, Message>(forwardMessage, "/forwardMessage", cancellationToken);

    /// <inheritdoc />
    public override async Task<TelegramResponse<MessageIdentifier>?> CopyMessageAsync(CopyMessage copyMessage, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<CopyMessage, MessageIdentifier>(copyMessage, "/copyMessage", cancellationToken);
    
    /// <inheritdoc />
    public override async Task<TelegramResponse<Message>?> SendPhotoAsync(SendPhoto sendPhoto, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendPhoto, Message>(sendPhoto, "/sendPhoto", cancellationToken);

    /// <inheritdoc />
    public override async Task<TelegramResponse<Message>?> SendAudioAsync(SendAudio sendAudio, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendAudio, Message>(sendAudio, "/sendAudio", cancellationToken);

    /// <inheritdoc />
    public override async Task<TelegramResponse<Message>?> SendFileAsync(SendFile sendFile, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendFile, Message>(sendFile, "/sendDocument", cancellationToken);

    /// <inheritdoc />
    public override async Task<TelegramResponse<Message>?> SendVideoAsync(SendVideo sendVideo, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendVideo, Message>(sendVideo, "/sendVideo", cancellationToken);

    /// <inheritdoc />
    public override async Task<TelegramResponse<Message>?> SendAnimationAsync(SendAnimation sendAnimation, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendAnimation, Message>(sendAnimation, "/sendAnimation", cancellationToken);

    /// <inheritdoc />
    public override async Task<TelegramResponse<Message>?> SendVoiceAsync(SendVoice sendVoice, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendVoice, Message>(sendVoice, "/sendVoice", cancellationToken);

    public override async Task<TelegramResponse<Message>?> SendVideoNoteAsync(SendVideoNote sendVideoNote, CancellationToken cancellationToken = default) =>
        await ExecuteCommand<SendVideoNote, Message>(sendVideoNote, "/sendVideoNote", cancellationToken);

    private async Task<TelegramResponse<TU>?> ExecuteCommand<T, TU>(
        T commandModel, 
        string command, 
        CancellationToken cancellationToken = default) 
        where T: ISendingEntity =>
        await HttpClient.PostAsJsonAsync<TelegramResponse<TU>?>(
            BaseBotUrl + command,
            commandModel,
            cancellationToken);
}