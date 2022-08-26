using System.Text.Json.Serialization;

namespace TestTaskP.Tests.Models
{
    internal class ReverseNumberResponse
    {
        [JsonPropertyName("result")]
        public double Result { get; set; }
    }
}
