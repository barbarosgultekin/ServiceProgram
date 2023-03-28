using Core.Signatures;
using System;

namespace DataAccess.Entities
{
    public class BranchOffice : BaseEntity
    {
        public BranchOffice()
        {
            CreatedAt = DateTime.Now;
        }
        public string BranchName { get; set; }                   
        public string Address { get; set; }                   
        public string Phone { get; set; }      
    }
}
