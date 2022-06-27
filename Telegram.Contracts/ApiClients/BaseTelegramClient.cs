using Telegram.Contracts.ApiClients.Interfaces;
using Telegram.Contracts.DTOs;
using Telegram.Contracts.DTOs.Messages;
using Telegram.Contracts.Events.Files;
using Telegram.Contracts.Events.Files.Animations;
using Telegram.Contracts.Events.Files.Audio;
using Telegram.Contracts.Events.Files.Photos;
using Telegram.Contracts.Events.Files.Video;
using Telegram.Contracts.Events.Messages;
using Telegram.Contracts.Settings;

namespace Telegram.Contracts.ApiClients;

/// <summary>
/// Базовый телеграмм клиент.
/// </summary>
public abstract class BaseTelegramClient : ITelegramClient
{
    protected readonly HttpClient HttpClient;
    protected readonly TelegramClientSettings TelegramClientSettings;

    protected readonly string BaseBotUrl;

    protected BaseTelegramClient(
        HttpClient httpClient, 
        TelegramClientSettings telegramClientSettings)
    {
        HttpClient = httpClient;
        TelegramClientSettings = telegramClientSettings;

        BaseBotUrl = telegramClientSettings.BaseUrl + telegramClientSettings.Token;
    }

    /// <inheritdoc />
    public abstract Task<TelegramResponse<User>?> GetBotInfoAsync(CancellationToken cancellationToken = default);

    /// <inheritdoc />
    public abstract Task<TelegramResponse<Message>?> SendMessageAsync(SendMessage sendMessage, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    public abstract Task<TelegramResponse<Message>?> ForwardMessageAsync(ForwardMessage forwardMessage, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    public abstract Task<TelegramResponse<MessageIdentifier>?> CopyMessageAsync(CopyMessage copyMessage, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    public abstract Task<TelegramResponse<Message>?> SendPhotoAsync(SendPhoto sendPhoto, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    public abstract Task<TelegramResponse<Message>?> SendAudioAsync(SendAudio sendAudio, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    public abstract Task<TelegramResponse<Message>?> SendFileAsync(SendFile sendFile, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    public abstract Task<TelegramResponse<Message>?> SendVideoAsync(SendVideo sendVideo, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    public abstract Task<TelegramResponse<Message>?> SendAnimationAsync(SendAnimation sendAnimation, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    public abstract Task<TelegramResponse<Message>?> SendVoiceAsync(SendVoice sendVoice, CancellationToken cancellationToken = default);

    public abstract Task<TelegramResponse<Message>?> SendVideoNoteAsync(SendVideoNote sendVideoNote, CancellationToken cancellationToken = default);
}