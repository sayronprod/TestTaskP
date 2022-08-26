namespace TestTaskP.Interfaces
{
    public interface IMainService
    {
        public Task<double> ProccessNumber(double data);
        public Task<string> ProccessString(string data);
    }
}
