using System.ComponentModel;

namespace Entity.DTO.RoleAuthorization
{
    public class ListRoleDTO
    {
        [DisplayName("Rol Adı")]
        public string Name { get; set; }
    }
}
