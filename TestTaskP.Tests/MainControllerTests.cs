using Microsoft.VisualStudio.TestPlatform.TestHost;
using Newtonsoft.Json;
using TestTaskP.Tests.Models;

namespace TestTaskP.Tests
{
    public class MainControllerTests : IClassFixture<TestingWebAppFactory<Program>>
    {
        private readonly HttpClient _client;

        public static IEnumerable<object[]> StringData =>
        new List<object[]>
        {
            new object[] { "test", "tset" },
            new object[] { "hello", "olleh" },
            new object[] { "qwerty", "ytrewq" }
        };

        public static IEnumerable<object[]> NumberData =>
        new List<object[]>
        {
            new object[] { 16d, 4d },
            new object[] { 64d, 8d },
            new object[] { 10.24d, 3.2d}
        };

        public MainControllerTests(TestingWebAppFactory<Program> factory)
        {
            _client = factory.CreateClient();
        }

        [Theory, MemberData(nameof(StringData))]
        public async Task Reverse_WhenString_ReturnReversedString(string data, string expected)
        {
            var getRequest = new HttpRequestMessage(HttpMethod.Get, $"/reverse?data={data}");
            var response = await _client.SendAsync(getRequest);
            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            var responseModel = JsonConvert.DeserializeObject<ReverseStringResponse>(responseString);

            Assert.NotNull(responseModel);
            Assert.NotNull(responseModel.Result);
            Assert.Equal(expected, responseModel.Result);
        }

        [Theory, MemberData(nameof(NumberData))]
        public async Task Reverse_WhenNumber_ReturnSqrtNumber(double data, double expected)
        {
            var getRequest = new HttpRequestMessage(HttpMethod.Get, $"/reverse?data={data}");
            var response = await _client.SendAsync(getRequest);
            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            var responseModel = JsonConvert.DeserializeObject<ReverseNumberResponse>(responseString);

            Assert.NotNull(responseModel);
            Assert.Equal(expected, responseModel.Result);
        }
    }
}