using System.Text.Json.Serialization;

namespace TestTaskP.DTOs.MainController
{
    public class ReverseResponse
    {
        [JsonPropertyName("result")]
        public object Result { get; set; } = default!;
    }
}
