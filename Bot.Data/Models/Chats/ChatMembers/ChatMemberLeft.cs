﻿namespace Bot.Data.Models.Chats.ChatMembers;

/// <summary>
/// Участник, который в данный момент не является участником чата, но может присоединиться к нему самостоятельно.
/// </summary>
/// <param name="User"></param>
public record ChatMemberLeft(
    User User) 
    : ChatMember
{
    protected override string Status { get; init; } = "left";
}