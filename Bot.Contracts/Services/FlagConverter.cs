using System;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using Bot.Contracts.DTO.Enums;

namespace Bot.Contracts.Services;

public class FlagConverter: JsonConverter<RolesDto>
{
    public override RolesDto Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => 
        Enum.Parse<RolesDto>(reader.GetString()!);

    public override void Write(Utf8JsonWriter writer, RolesDto value, JsonSerializerOptions options)
    {
        var flags = value
            .ToString()
            .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
            .Select(f => $"\"{f}\"");

        writer.WriteRawValue($"[{string.Join(", ", flags)}]");
    }
}