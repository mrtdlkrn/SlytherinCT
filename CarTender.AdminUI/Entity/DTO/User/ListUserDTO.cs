using System;
using System.ComponentModel;

namespace Entity.DTO.User
{
    public class ListUserDTO
    {
        [DisplayName("Kullanıcı adı")]
        public string UserName { get; set; }

        [DisplayName("İsim Soyisim")]
        public string NameSurname { get; set; }

        [DisplayName("Telefon")]
        public string Phone { get; set; }

        [DisplayName("Eposta")]
        public string Email { get; set; }

        [DisplayName("Kullanıcı Tipi")]
        public string UserType { get; set; }

        [DisplayName("Onaylayan")]
        public string ApprovedBy { get; set; }

        [DisplayName("Kayıt Tarihi")]
        public DateTime CreatedDate { get; set; }
    }
}
