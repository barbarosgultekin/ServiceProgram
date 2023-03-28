using Core.Signatures;
using System;

namespace DataAccess.Entities
{
    public class Customer : BaseEntity
    {
        public Customer()
        {
            CreatedAt = DateTime.Now;
        }
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
