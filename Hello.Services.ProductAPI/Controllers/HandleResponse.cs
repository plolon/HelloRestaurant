using Hello.Services.ProductAPI.DTOs;

namespace Hello.Services.ProductAPI.Controllers
{
    public static class HandleResponse
    {
        public static ResponseDto GetFailedResponse(this Exception ex)
        {
            return new ResponseDto
            {
                Success = false,
                ErrorMessages = new List<string> { ex.ToString() },
                Message = ex.Message
            };
        }
        public static ResponseDto GetSuccessResponse(object result, string message)
        {
            return new ResponseDto
            {
                Success = true,
                Result = result,
                Message = message
            };
        }
    }
}
