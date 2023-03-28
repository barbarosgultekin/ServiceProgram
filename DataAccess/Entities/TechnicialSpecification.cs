using Core.Signatures;
using System;

namespace DataAccess.Entities
{
    public class TechnicialSpecification:BaseEntity
    {
        public TechnicialSpecification()
        {
            CreatedAt = DateTime.Now;
        }

        public string Description { get; set; }
    }
}
