using System.ComponentModel;

namespace Entity.DTO.Role
{
    public class AddRoleDTO
    {
        [DisplayName("Rol Adı")]
        public string Name { get; set; }
    }
}
