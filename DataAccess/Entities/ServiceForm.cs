using Core.Signatures;
using System;
using System.Collections.Generic;

namespace DataAccess.Entities
{
    public class ServiceForm:BaseEntity
    {
        public ServiceForm()
        {
            CreatedAt = DateTime.Now;
        }
        public int CompanyId { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public string ReportNumber { get; set; }
        public DateTime ServiceStart { get; set; }
        public DateTime ServiceEnd { get; set; }
        public string Failure { get; set; }
        public string Repair { get; set; }
        public double Price { get; set; }
        public ICollection<Accessory> Accessory { get; set; }


    }
}
