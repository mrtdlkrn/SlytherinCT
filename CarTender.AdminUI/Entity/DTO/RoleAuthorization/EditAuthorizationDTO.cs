using System.ComponentModel;

namespace Entity.DTO.RoleAuthorization
{
    public class EditAuthorizationDTO
    {
        [DisplayName("Rol Adı")]
        public string Name { get; set; }
    }
}
