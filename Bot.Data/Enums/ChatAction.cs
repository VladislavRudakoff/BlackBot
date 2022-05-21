namespace Bot.Data.Enums;

/// <summary>
/// Type of action to broadcast
/// </summary>
public enum ChatAction
{
    /// <summary>
    /// Typing
    /// </summary>
    Typing = 1,

    /// <summary>
    /// Uploading a <see cref="PhotoSize"/>
    /// </summary>
    UploadPhoto = 2,

    /// <summary>
    /// Recording a <see cref="Video"/>
    /// </summary>
    RecordVideo = 3,

    /// <summary>
    /// Uploading a <see cref="Video"/>
    /// </summary>
    UploadVideo = 4,

    /// <summary>
    /// Recording a <see cref="Voice"/>
    /// </summary>
    RecordVoice = 5,

    /// <summary>
    /// Uploading a <see cref="Voice"/>
    /// </summary>
    UploadVoice = 6,

    /// <summary>
    /// Uploading a <see cref="Document"/>
    /// </summary>
    UploadDocument = 7,

    /// <summary>
    /// Finding a <see cref="Location"/>
    /// </summary>
    FindLocation = 8,

    /// <summary>
    /// Recording a <see cref="VideoNote"/>
    /// </summary>
    RecordVideoNote = 9,

    /// <summary>
    /// Uploading a <see cref="VideoNote"/>
    /// </summary>
    UploadVideoNote = 10,

    /// <summary>
    /// Choosing a <see cref="Sticker"/>
    /// </summary>
    ChooseSticker = 11
}