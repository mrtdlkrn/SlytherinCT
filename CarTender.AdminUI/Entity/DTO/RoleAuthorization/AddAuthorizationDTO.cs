using System.ComponentModel;

namespace Entity.DTO.RoleAuthorization
{
    public class AddAuthorizationDTO
    {
        [DisplayName("Yetki Adı")]
        public string Name { get; set; }
    }
}
