using Core.Signatures;

namespace Business.Models.BaseDTO
{
    public class CustomerDto :IBaseDto
    {
        public string CompanyName { get; set; }
        public string CommercialTitle { get; set; }
        public string Address { get; set; }
        public string TaxOffice { get; set; }
        public string TaxNo { get; set; }
        public string ContactPerson { get; set; }
        public string Mail { get; set; }
        public string Gsm { get; set; }
        public string Phone { get; set; }
        public string Detail { get; set; }
        public string Sector { get; set; }        
    }
}
