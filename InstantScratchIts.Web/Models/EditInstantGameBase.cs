using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InstantScratchIts.Web.Models
{
    public class EditInstantGameBase
    {
        [Required, StringLength(100), DisplayName("Name of the Game")]
        public string Name { get; set; }
        [Range(1000, 9999), DisplayName("Game Number")]
        public int GameNo { get; set; }
        [Range(1, 50), DisplayName("Ticket Amount")]
        public decimal TicketAmount { get; set; }
      
    }
}
