using Core.Signatures;
using System;

namespace Business.Models.BaseDTO
{
    public class ServiceFormDto:IBaseDto
    {
        public int ReportNumber { get; set; }
        public DateTime ServiceStart { get; set; }
        public DateTime ServiceEnd { get; set; }
        public string Failure { get; set; }
        public string Repair { get; set; }
        public string Price { get; set; }
        public string Accessory { get; set; }      
    }
}
