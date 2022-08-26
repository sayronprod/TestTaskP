using System.Text.Json.Serialization;

namespace TestTaskP.Tests.Models
{
    internal class ReverseStringResponse
    {
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
