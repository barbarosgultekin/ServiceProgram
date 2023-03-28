using Core.Signatures;
using System;

namespace DataAccess.Entities
{
    public class UserClaim:BaseEntity
    {
        public UserClaim()
        {
            CreatedAt = DateTime.Now;
        }
        public string Name { get; set; }       
    }
}
