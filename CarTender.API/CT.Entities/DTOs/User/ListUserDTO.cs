using System;

namespace CT.Entities.DTOs.User
{
    public class ListUserDTO
    {
        public string UserName { get; set; }
        public string NameSurname  { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string UserType { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
