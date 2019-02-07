using System.Collections.Generic;

namespace InstantScratchIts.Web.Models
{
    public class InstantGameDetailViewModel
    {
        public int Id { get; set; }
        public int GameNo { get; set; }
        public string Name { get; set; }
        public decimal TicketAmount { get; set; }

        public IEnumerable<Region> Jurisdictions { get; set; }

        public class Region
        {
            public string Name { get; set; }
            public int Allocation { get; set; }
        }
    }
}
