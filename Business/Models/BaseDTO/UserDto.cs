using Core.Signatures;
using DataAccess.Entities;
using System;

namespace Business.Models.BaseDTO
{
    public class UserDto : IBaseDto
    {
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
    }
}