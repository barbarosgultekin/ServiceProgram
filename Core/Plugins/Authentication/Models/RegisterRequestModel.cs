using System;

namespace Core.Plugins.Authentication.Models
{
    public class RegisterRequestModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public int GenderId { get; set; }      
        public bool IsBlocked { get; set; }
        public int UserClaim { get; set; }
        public int BranchOfficeId { get; set; }        
        public DateTime Birthday { get; set; }
    }
}