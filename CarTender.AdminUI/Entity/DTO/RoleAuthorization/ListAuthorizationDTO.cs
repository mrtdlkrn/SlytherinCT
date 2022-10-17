using System.ComponentModel;

namespace Entity.DTO.RoleAuthorization
{
    public class ListAuthorizationDTO
    {
        [DisplayName("Yetki Adı")]
        public string Name { get; set; }
    }
}
