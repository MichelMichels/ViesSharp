using System.Text.Json.Serialization;

namespace MichelMichels.ViesSharp.Models;

public class ErrorResponse
{
    [JsonPropertyName("actionSucceed")]
    public bool IsActionSucceeded { get; set; }

    [JsonPropertyName("errorWrappers")]
    public ErrorWrapper[] ErrorWrappers { get; set; } = [];
}