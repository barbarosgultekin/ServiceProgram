using Core.Signatures;

namespace Business.Models.BaseListDTO
{
    public class BranchOfficesDto:IBaseListDto
    {
        public int Id { get; set; }
        public string BranchName { get; set; }
        
    }
}
