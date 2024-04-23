﻿using System.Text.Json.Serialization;

namespace MichelMichels.ViesSharp.Models;

public class ErrorWrapper
{
    [JsonPropertyName("error")]
    public string Error { get; set; } = string.Empty;

    [JsonPropertyName("message")]
    public string Message { get; set; } = string.Empty;
}
