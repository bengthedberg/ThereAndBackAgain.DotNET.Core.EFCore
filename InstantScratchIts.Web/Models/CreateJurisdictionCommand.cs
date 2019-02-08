using InstantScratchIts.Web.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InstantScratchIts.Web.Models
{
    public class CreateJurisdictionCommand
    {
   
        [Required, StringLength(100)]
        public string Name { get; set; }
        [Range(0, int.MaxValue)]
        public decimal RetailCommissionAmount { get; set; }
        public DateTime StartSellDate { get; set; }
        public DateTime StopSellDate { get; set; }
        public TimeSpan ValidationPeriod  { get; set; }
        public int Allocation { get; set; }

        public Jurisdiction ToJurisdiction()
        {
            return new Jurisdiction
            {
                Name = Name,
                Allocation = Allocation,
                RetailCommissionAmount = RetailCommissionAmount,
                StartSellDate = DateTime.Now,
                StopSellDate = DateTime.Now,
                ValidationPeriod = TimeSpan.FromHours(12)                
            };
        }
    }
}
