using System.Collections.Generic;

namespace Entity.DTO.RoleAuthorization
{
    public class AuthorizationViewDTO
    {
        public List<ListAuthorizationDTO> Auths { get; set; }
        public List<ListRoleDTO> Roles { get; set; }
    }
}
