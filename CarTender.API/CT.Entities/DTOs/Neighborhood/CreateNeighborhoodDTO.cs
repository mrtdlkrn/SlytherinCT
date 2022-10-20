using System.Collections.Generic;
using System.ComponentModel;

namespace CT.Entities.DTOs.Neighborhood
{
    // todo: create ve update dto'ların içerisindeki prop'lar gözden geçirilip düzenlenecek.
    public class CreateNeighborhoodDTO
    {
        public string Name { get; set; }
        public string Towns { get; set; }
    }
}
