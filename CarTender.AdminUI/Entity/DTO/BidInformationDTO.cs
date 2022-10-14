using System;

namespace Entity
{
    public class BidInformationDTO
    {
        public string BidName { get; set; }
        public bool IsCorporate { get; set; }
        public bool IsApproved { get; set; }
        public DateTime? FinishedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? ApprovedBy { get; set; }
        public Guid? FinishedBy { get; set; }
        public Guid CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public Guid? UserID { get; set; }
        public bool IsActive { get; set; }
        public TimeSpan? Version { get; set; }
        public Guid? AddressInformationID { get; set; }

        //todo: fk olan tabloları çekmedik...

    }
}
