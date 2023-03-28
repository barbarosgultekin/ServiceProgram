using Core.Signatures;

namespace Business.Models.BaseDTO
{
    public class ProductDto : IBaseDto
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Serial { get; set; }
        public string ArticleNumber { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
    }
}
