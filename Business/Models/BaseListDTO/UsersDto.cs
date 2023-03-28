using Core.Signatures;
using DataAccess.Entities;
using System;

namespace Business.Models.BaseListDto
{
    public class UsersDto : IBaseListDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsBlocked { get; set; }
        public int UserClaim { get; set; }       
        public DateTime Birthday { get; set; }

        public string BranchOffice { get; set; }
        public string Gender { get; set; }      
    }

}