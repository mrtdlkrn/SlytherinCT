namespace CT.Entities.Entities
{
    public class Town
    {
        public string TownName { get; set; }

        public int CityID { get; set; }
        public City City { get; set; }
    }
}
