namespace CT.Entities.DTOs.User
{
    public class ListUserFavoriteCarDTO
    {
        public string UserEmail { get; set; }
        public string UserNameSurname { get; set; }
        public string CarPlate { get; set; }
        public string CarModel { get; set; }
        public string CarBrand { get; set; }
        public int CarPrice { get; set; }
    }
}
