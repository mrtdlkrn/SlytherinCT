using System.ComponentModel;

namespace Entity.DTO.Role
{
    public class EditRoleDTO
    {
        [DisplayName("Rol Adı")]
        public string Name { get; set; }
    }
}
