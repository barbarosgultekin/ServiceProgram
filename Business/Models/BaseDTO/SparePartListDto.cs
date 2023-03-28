using Core.Signatures;
namespace Business.Models.BaseDTO
{
    public class SparePartListDto : IBaseDto 
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public string Serial { get; set; }
        public string ArticleNumber { get; set; }
        public string Box { get; set; }
        public string Price { get; set; }      
    }
}
