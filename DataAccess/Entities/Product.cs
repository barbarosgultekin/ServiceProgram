using Core.Signatures;
using System;

namespace DataAccess.Entities
{
    public class Product: BaseEntity
    {
        public Product()
        {
            CreatedAt = DateTime.Now;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Serial { get; set; }
        public string ArticleNumber { get; set; }
        public string Description { get; set; }       
        public string Detail { get; set; }
        public int TechSpecId { get; set; }
    }
}
