using InstantScratchIts.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstantScratchIts.Web.Models
{
    public class UpdateInstantGameCommand : EditInstantGameBase
    {
        public int Id { get; set; }

        public void UpdateInstantGame(InstantGame game)
        {
            game.Name = Name;
            game.GameNo = GameNo;
            game.TicketAmount = TicketAmount;
        }
    }
}
