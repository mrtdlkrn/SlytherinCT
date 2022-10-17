using System;

namespace Entity.DTO.Location
{
    public class NeighborhoodDTO
    {
        public Guid DistrictID { get; set; }
        public string NeighborhoodName { get; set; }
        public bool IsActive { get; set; }
        public TimeSpan? Version { get; set; }
    }
}
