using System;
using System.Collections.Generic;

namespace InstantScratchIts.Web.Data
{
    public class InstantGame
    {
        public int InstantGameId { get; set; }
        public int GameNo { get; set; }
        public string Name { get; set; }
        public decimal TicketAmount { get; set; } 
        
        public bool IsDeleted { get; set; }

        public ICollection<Jurisdiction> Jurisdiction { get; set; }
    
    }
}