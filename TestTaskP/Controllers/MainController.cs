using Microsoft.AspNetCore.Mvc;
using TestTaskP.DTOs.MainController;
using TestTaskP.Interfaces;

namespace TestTaskP.Controllers
{
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly IMainService _mainService;
        public MainController(IMainService mainService)
        {
            _mainService = mainService;
        }

        [Route("reverse")]
        [HttpGet]
        public async Task<ReverseResponse> Reverse(string data)
        {
            ReverseResponse response = new ReverseResponse();

            double? number = data.ToNumber();
            if (number != null)
            {
                response.Result = await _mainService.ProccessNumber(number.Value);
            }
            else
            {
                response.Result = await _mainService.ProccessString(data);
            }

            return response;
        }
    }
}