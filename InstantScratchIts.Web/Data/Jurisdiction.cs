using System;
using System.Collections.Generic;

namespace InstantScratchIts.Web.Data
{
    public class Jurisdiction
    {
        public int JurisdictionId { get; set; }
        public int InstantGameId { get; set; }
        public string Name { get; set; }
        public decimal RetailCommissionAmount { get; set; }
        public DateTime StartSellDate { get; set; }
        public DateTime StopSellDate { get; set; }
        public TimeSpan ValidationPeriod { get; set; }
        public int Allocation { get; set; }
    }
}