namespace CT.Entities.DTOs.User
{
    public class CreateUserDTO
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Information { get; set; }
        public bool IsCorporate { get; set; }
        public bool IsKVKKApproved { get; set; }
    }
}
