using InstantScratchIts.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstantScratchIts.Web.Models
{
    public class CreateInstantGameCommand : EditInstantGameBase
    {
        public IList<CreateJurisdictionCommand> Regions { get; set; } = new List<CreateJurisdictionCommand>();

        public InstantGame ToInstantGame()
        {
            return new InstantGame
            {
                Name = Name,
                GameNo = GameNo,
                TicketAmount = TicketAmount,
                Jurisdictions = Regions?.Select(x => x.ToJurisdiction()).ToList()
            };
        }
    }
}
