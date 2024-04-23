using System.Text.Json.Serialization;

namespace MichelMichels.ViesSharp.Models
{
    public class VatNumberResponse
    {
        [JsonPropertyName("countryCode")]
        public string CountryCode { get; set; } = string.Empty;

        [JsonPropertyName("vatNumber")]
        public string VatNumber { get; set; } = string.Empty;

        [JsonPropertyName("requestDate")]
        public DateTime? RequestDate { get; set; }

        [JsonPropertyName("valid")]
        public bool IsValid { get; set; }

        [JsonPropertyName("requestIdentifier")]
        public string RequestIdentifier { get; set; } = string.Empty;

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("address")]
        public string Address { get; set; } = string.Empty;

        [JsonPropertyName("traderName")]
        public string TraderName { get; set; } = string.Empty;

        [JsonPropertyName("traderStreet")]
        public string TraderStreet { get; set; } = string.Empty;

        [JsonPropertyName("traderPostalCode")]
        public string TraderPostalCode { get; set; } = string.Empty;

        [JsonPropertyName("traderCity")]
        public string TraderCity { get; set; } = string.Empty;

        [JsonPropertyName("traderCompanyType")]
        public string TraderCompanyType { get; set; } = string.Empty;

        [JsonPropertyName("traderNameMatch")]
        public string TraderNameMatch { get; set; } = string.Empty;

        [JsonPropertyName("traderStreetMatch")]
        public string TraderStreetMatch { get; set; } = string.Empty;

        [JsonPropertyName("traderPostalCodeMatch")]
        public string TraderPostalCodeMatch { get; set; } = string.Empty;

        [JsonPropertyName("traderCityMatch")]
        public string TraderCityMatch { get; set; } = string.Empty;

        [JsonPropertyName("traderCompanyTypeMatch")]
        public string TraderCompanyTypeMatch { get; set; } = string.Empty;
    }
}

