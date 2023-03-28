using Core.Signatures;
using System;

namespace DataAccess.Entities
{
    public class SparePartList:BaseEntity
    {
        public SparePartList()
        {
            CreatedAt = DateTime.Now;
        }
        public string Description { get; set; }
        public string PartType { get; set; }
        public string Name { get; set; }
        public string Serial { get; set; }
        public string ArticleNumber { get; set; }
        public string Box { get; set; }
        public string Price { get; set; }
    }
}
