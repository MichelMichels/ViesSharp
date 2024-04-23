using System.Text.Json.Serialization;

namespace MichelMichels.ViesSharp.Models;

public class StatusResponse
{
    [JsonPropertyName("vow")]
    public Vow? Vow { get; set; }

    [JsonPropertyName("countries")]
    public Country[] Countries { get; set; } = [];
}
