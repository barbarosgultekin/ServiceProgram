using Core.Signatures;
using System;

namespace DataAccess.Entities
{
    public class User : BaseEntity
    {
        public User()
        {
            CreatedAt = DateTime.Now;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsBlocked { get; set; }
        public int UserClaim { get; set; }
        public DateTime Birthday { get; set; }

        public int BranchOfficeId { get; set; }
        public int GenderId { get; set; }
        public BranchOffice BranchOffice { get; set; }
        public Gender Gender { get; set; }
    }
}
