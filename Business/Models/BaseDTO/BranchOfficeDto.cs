using Core.Signatures;

namespace Business.Models.BaseDTO
{
    public class BranchOfficeDto:IBaseDto
    {
        public string BranchName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
