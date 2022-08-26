using TestTaskP.Interfaces;

namespace TestTaskP.Services
{
    public class MainService : IMainService
    {
        public Task<double> ProccessNumber(double data)
        {
            return Task.FromResult(Math.Sqrt(data));
        }

        public Task<string> ProccessString(string data)
        {
            char[] charArray = data.ToCharArray();
            Array.Reverse(charArray);
            return Task.FromResult(new string(charArray));
        }
    }
}
