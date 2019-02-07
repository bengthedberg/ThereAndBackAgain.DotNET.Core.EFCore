using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstantScratchIts.Web.Data;

namespace InstantScratchIts.Web.Models
{
    public class InstantGamesSummaryViewModel
    {
        public int Id { get; set; }
        public int GameNo { get; set; }
        public string Name { get; set; }
        public decimal TicketAmount { get; set; }

        public static InstantGamesSummaryViewModel FromInstantGame(InstantGame instantGame)
        {
            return new InstantGamesSummaryViewModel
            {
                Id = instantGame.InstantGameId,
                GameNo = instantGame.GameNo,
                Name = instantGame.Name,
                TicketAmount = instantGame.TicketAmount
            };
        }
    }
}
