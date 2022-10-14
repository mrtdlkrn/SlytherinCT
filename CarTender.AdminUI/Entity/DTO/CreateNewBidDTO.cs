﻿using System;

namespace Entity.DTO
{
    public class CreateNewBidDTO
    {
        public string BidName { get; set; }
        public bool CustomerType { get; set; }
        public string CompanyName { get; set; }
        public string Statü { get; set; }
        public DateTime BidStartDate { get; set; }
        public string BidStartTime { get; set; }
        public DateTime BidEndDate { get; set; }
        public string BidEndTime { get; set; }
    }
}
