using System;

namespace CarTender.FluentValidation.DTO.CombineDTO
{
    public class BaseDTO
    {
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
        public string Version { get; set; }
    }
}
