namespace Tasty.Services.ProductAPI.Models.Dto
{
    public class ResponseDto
    {
        public bool IsSuccess { get; set; } = true;
        public object Reslt { get; set; }
        public string DisplayMessage { get; set; } = "";
        public List<String> ErrorMessages { get; set; }
    }
}
