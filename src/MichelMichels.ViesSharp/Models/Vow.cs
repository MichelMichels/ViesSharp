using System.Text.Json.Serialization;

namespace MichelMichels.ViesSharp.Models;

public class Vow
{
    [JsonPropertyName("available")]
    public bool IsAvailable { get; set; }
}
